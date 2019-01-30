using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankDbApi.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomer _customer;

        public CustomersController(ICustomer customer)
        {
            _customer = customer;
        }

        // POST api/customers
        [HttpPost]
        public ActionResult<Customer> Post(Customer customer)
        {
            return _customer.Create(customer);
        }

        // PUT api/customers/5
        [HttpPut("{id}")]
        public ActionResult<Customer> Put(int id, Customer customer)
        {
            return _customer.Update(customer);
        }

        // DELETE api/customers/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _customer.Delete(id);
            return new NoContentResult();
        }
    }
}