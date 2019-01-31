using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankDbApi.Models;

namespace BankDbApi.Services
{
    public class AccountService : IAccountService
    {
      

        public Account CreateAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public void Delete(string IBAN)
        {
            throw new NotImplementedException();
        }

        public List<Account> Read()
        {
            throw new NotImplementedException();
        }

        public Account Read(string IBAN)
        {
            throw new NotImplementedException();
        }

        public Account Update(string IBAN, Account account)
        {
            throw new NotImplementedException();
        }
    }
}
