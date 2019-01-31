using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankDbApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BankDbApi.Repositories
{
    public class TransactionRepository: ITransactionRepository
    {
        private readonly BankdbContext _context;

        public TransactionRepository(BankdbContext context)
        {
            _context = context;
        }
        public Transaction Create(Transaction transaction)
        {
            _context.Add(transaction);
            _context.SaveChanges();
            return transaction;
        }

        public List<Transaction> Read()
        {
            return _context.Transaction.AsNoTracking().ToList();
        }

        public Transaction Read(int id)
        {
            return _context.Transaction.AsNoTracking().FirstOrDefault(p => p.Id == id);
        }

        public Transaction Update(int id, Transaction transaction)
        {
            _context.Update(transaction);
            _context.SaveChanges();
            return transaction;
        }

        public void Delete(int id)
        {
            var transaction = Read(id);
            _context.Transaction.Remove(transaction);
            _context.SaveChanges();
          
        }
    }
}
