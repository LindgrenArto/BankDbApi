using System.Collections.Generic;
using BankDbApi.Models;

namespace BankDbApi.Repositories
{
    public class Bank: IBank
    {
        private readonly BankdbContext _context;

        public Bank(BankdbContext context)
        {
            _context = context;
        }

        //Create 

        public Bank Create(Bank bank)
        {
            _context.Add(bank);
            _context.SaveChanges();
            return bank;
        }
       
        //list

        public List<Bank> Read()
        {
            // mitä tähän?
            return null;
        }

        public Bank Read(int id)
        {

            return null;

        }

        public Bank Update(int id, Bank bank)
        {
            _context.Update(bank);
            _context.SaveChanges();
            return bank;
        }

        public void Delete(int id)
        {
            
            _context.Account.Remove(id);// ?????
            _context.SaveChanges();
            
        }

    }
}
