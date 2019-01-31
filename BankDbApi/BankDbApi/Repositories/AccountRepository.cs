using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BankDbApi.Models;
using BankDbApi.Repositories;
using Remotion.Linq.Clauses;

namespace BankDbApi.Repositories
{
    public class AccountRepository: IAccountRepository
    {
        private readonly BankdbContext _context;

        public AccountRepository(BankdbContext context)
        {
            _context = context;
        }

        //Create

        public Account Create(Account account)
        {
            _context.Add(account);
            _context.SaveChanges();
            return account;
        }

       //printing list , not working


       public List<Account> Read()
       {

           return _context.Account.AsNoTracking().Include(p=>p.Transaction).ToList();

       }
        //By id, not working
       public Account Read(string IBAN)
       {
           return _context.Account.AsNoTracking().Include("Transaction").FirstOrDefault(p => p.IBAN == IBAN);
       }
        // Update
       public Account Update(string IBAN, Account account)
       {
           _context.Update(account);
           _context.SaveChanges();
           return account;
       }

       //Delete
       public void Delete(string IBAN)
       {
           var account = Read(IBAN);
           _context.Account.Remove(account); // ??????
           _context.SaveChanges();
           return;
       }

    }
}
