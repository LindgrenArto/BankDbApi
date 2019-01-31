using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankDbApi.Models;

namespace BankDbApi.Repositories
{
    public interface IAccountRepository
    {
        Account Create(Account account);
        List<Account> Read();
        Account Read(string IBAN);
        Account Update(string IBAN, Account account);
        void Delete(string IBAN);
    }
}
