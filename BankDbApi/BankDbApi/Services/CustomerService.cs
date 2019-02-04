using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankDbApi.Models;
using BankDbApi.Repositories;
using BankDbApi.Utilities;

namespace BankDbApi.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer CreateCustomer(Customer customer)
        {
            customer.Psw = PasswordHash.HashPassword(customer.Psw, "salt");
            return _customerRepository.Create(customer);
        }

        public void Delete(int id)
        {
            _customerRepository.Delete(id);
        }

        public List<Customer> Read()
        {
            return _customerRepository.Read();
        }

        public Customer Read(int id)
        {
            return _customerRepository.Read(id);
        }

        public Customer Update(int id, Customer customer)
        {
            var savedCustomer = _customerRepository.Read(id);
            if(savedCustomer == null)
            {
                throw new Exception("Customer not found");
            }
            else
            {
                customer.Psw = PasswordHash.HashPassword(customer.Psw, "salt");
                return _customerRepository.Update(id, customer);
            }
        }
    }
}
