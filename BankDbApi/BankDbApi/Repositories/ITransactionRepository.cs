using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankDbApi.Models;

namespace BankDbApi.Repositories
{
    public interface ITransactionRepository
    {

        Transaction Create(Transaction transaction);
        List<Transaction> Read();
        Transaction Read(int id);
        Transaction Update(int id, Transaction transcation);
        void Delete(int id);

    }
}
