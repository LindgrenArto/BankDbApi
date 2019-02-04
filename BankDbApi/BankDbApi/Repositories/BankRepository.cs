using System.Collections.Generic;
using System.Linq;
using BankDbApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BankDbApi.Repositories
{
    public class BankRepository: IBankRepository
    {
        private readonly BankdbContext _context;

        public BankRepository (BankdbContext context)
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
            return _context.Bank.AsNoTracking()
                .Include(c => c.Customer)
                .ToList();
        }

        public Bank Read(int id)
        {
            return _context.Bank.AsNoTracking().Include(c=>c.Customer).FirstOrDefault(p => p.Id == id);

        }

        public Bank Update(int id, Bank bank)
        {
            _context.Update(bank);
            _context.SaveChanges();
            return bank;
        }

        public void Delete(int id)
        {
            var bank = Read(id);
            _context.Bank.Remove(bank);
            _context.SaveChanges();
            
        }

    }
}
