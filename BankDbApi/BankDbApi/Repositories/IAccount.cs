using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankDbApi.Models.Repositories
{
    public interface IAccount
    {
        Account Create(Account account);
        List<Bank> Read();
        Account Read(int id);
        Account Update(int id, Bank bank);
        void Delete(int id);
    }
}
