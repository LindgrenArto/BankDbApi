using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BankDbApi.Models;
using BankDbApi.Services;

namespace BankDbApi.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        //by id
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            return new JsonResult(_customerService.Read(id));
        }


        // GET api/customers
        [HttpGet]
        public ActionResult<List<Customer>> GetCustomers()
        {
            return new JsonResult(_customerService.Read());
        }

        // POST api/customers
        [HttpPost]
        public ActionResult<Customer> Post(Customer customer)
        {
            return _customerService.CreateCustomer(customer);
        }

        // PUT api/customers/5
        [HttpPut("{id}")]
        public ActionResult<Customer> Put(int id, Customer customer)
        {
            return _customerService.Update(id, customer);
        }

        // DELETE api/customers/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _customerService.Delete(id);
            return new NoContentResult();
        }
    }
}