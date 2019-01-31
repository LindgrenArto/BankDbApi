using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankDbApi.Models;

namespace BankDbApi.Services
{
   public interface IBankService
    {
        Bank CreateBank(Bank bank);
        List<Bank> Read();
        Bank Read(int id);
        Bank Update(int id, Bank bank);
        void Delete(int id);
    }
}
