using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankDbApi.Models;

namespace BankDbApi.Services
{
    interface ITransactionService
    {
        Transaction CreateTransaction(Transaction transaction);
        List<Transaction> Read();
        Transaction Read(int id);
        Transaction Update(int id, Transaction transaction);
        void Delete(int id);
    }
}
