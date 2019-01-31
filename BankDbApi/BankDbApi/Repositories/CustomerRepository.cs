using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankDbApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BankDbApi.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly BankdbContext _context;

        public CustomerRepository(BankdbContext context)
        {
            _context = context;
        }
        //create
        public Customer Create(Customer customer)
        {
            _context.Add(customer);
            _context.SaveChanges();
            return customer;


        }
        //list
        public List<Customer> Read()
        {
            return _context.Customer.AsNoTracking().Include(p => p.Account).ToList();


        }
        //by id
        public Customer Read(int id)
        {
            return _context.Customer.AsNoTracking().Include("Account").FirstOrDefault(p => p.Id == id);
        }

        public Customer Update(int id, Customer customer)
        {
            _context.Update(customer);
            _context.SaveChanges();
            return customer;
        }

        public void Delete(int id)
        {
            var customer = Read(id);
            _context.Customer.Remove(customer);
            _context.SaveChanges();
            return;
        }
    }
}
