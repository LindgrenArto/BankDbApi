﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankDbApi.Models;

namespace BankDbApi.Repositories
{
    public interface ICustomerRepository
    {
        Customer Create(Customer customer);
        List<Customer> Read();
        Customer Read(int id);
        Customer Update(int id, Customer customer);
        void Delete(int id);
    }
}
