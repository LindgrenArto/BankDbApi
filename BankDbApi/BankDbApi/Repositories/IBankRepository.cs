using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankDbApi.Models;
namespace BankDbApi.Repositories
{
    public interface IBankRepository
    {
        Bank Create(Bank bank);
        List<Bank> Read();
        Bank Read(int id);
        Bank Update(int id, Bank bank);
        void Delete(int id);
    }
}
