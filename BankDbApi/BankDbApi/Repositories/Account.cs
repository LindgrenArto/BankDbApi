using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BankDbApi.Models;
using BankDbApi.Models.Repositories;

namespace BankDbApi.Repositories
{
    public class Account: IAccount
    {
        private readonly BankdbContext _context;

        public Account(BankdbContext context)
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

       //printing list


       public List<Account> Read()
       {

           //Mitä tähän??

           return _context.Account.ToList();

       }

       public Account Read(int id)
       {
           return null;
       }

       public Account Update(int id, Account account)
       {
           _context.Update(account);
           _context.SaveChanges();
           return account;
       }

       public void Delete(int id)
       {
           var person = Read(id);
           _context.Account.Remove(account);
           _context.SaveChanges();
           return;
       }

    }
}
