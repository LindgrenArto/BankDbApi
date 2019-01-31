using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankDbApi.Models;
using BankDbApi.Repositories;

namespace BankDbApi.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public Transaction CreateTransaction(Transaction transaction)
        {
            return _transactionRepository.Create(transaction);
        }

        public void Delete(int id)
        {
            _transactionRepository.Delete(id);
        }

        public List<Transaction> Read()
        {
            return _transactionRepository.Read();
        }

        public Transaction Read(int id)
        {
            return _transactionRepository.Read(id);
        }

        public Transaction Update(int id, Transaction transaction)
        {
            var savedTransaction = _transactionRepository.Read(id);
            if(savedTransaction == null)
            {
                throw new Exception("Transaction not found");
            }
            else
            {
                return _transactionRepository.Update(id, transaction);
            }
        }
    }
}
