using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankDbApi.Models;
using BankDbApi.Repositories;

namespace BankDbApi.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountrepository;

        public AccountService(IAccountRepository accountrepository)
        {
            _accountrepository = accountrepository;
        }

        public Account CreateAccount(Account account)
        {
            return _accountrepository.Create(account);
        }

        public void Delete(string IBAN)
        {
            _accountrepository.Delete(IBAN);
        }

        public List<Account> Read()
        {
            return _accountrepository.Read();
        }

        public Account Read(int customerId)
        {
            return _accountrepository.Read(customerId);
        }

        public Account Read(string IBAN)
        {
            return _accountrepository.Read(IBAN);
        }

        public Account Update(string IBAN, Account account)
        {
            var savedAccount = _accountrepository.Read(IBAN);
            if(savedAccount == null)
            {
                throw new Exception("Account not found");
            }
            else
            {
                return _accountrepository.Update(IBAN,account);
            }

        }
    }
}
