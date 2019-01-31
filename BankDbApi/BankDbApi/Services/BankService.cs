using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankDbApi.Models;
using BankDbApi.Repositories;

namespace BankDbApi.Services
{
    public class BankService : IBankService
    {
        private readonly IBankRepository _bankRepository;

        public BankService(IBankRepository bankRepository)
        {
            _bankRepository = bankRepository;
        }

        public Bank CreateBank(Bank bank)
        {
            return _bankRepository.Create(bank);
        }

        public void Delete(int id)
        {
            _bankRepository.Delete(id);
        }

        public List<Bank> Read()
        {
            return _bankRepository.Read();
        }

        public Bank Read(int id)
        {
            return _bankRepository.Read(id);
        }

        public Bank Update(int id, Bank bank)
        {
            var savedBank = _bankRepository.Read(id);
            if(savedBank == null)
            {
                throw new Exception("Bank not found");
            }
            else
            {
                return _bankRepository.Update(id, bank);
            }
        }
    }
}
