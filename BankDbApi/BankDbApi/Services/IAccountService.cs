using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankDbApi.Models;

namespace BankDbApi.Services
{
    public interface IAccountService
    {
        Account CreateAccount(Account account);
        List<Account> Read();
        Account Read(int customerId);
        Account Read(string IBAN);
        Account Update(string IBAN, Account account);
        void Delete(string IBAN);
    }
}
