﻿using System;
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
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // POST api/customers
        [HttpPost]
        public ActionResult<Customer> Post(Customer customer)
        {
            return _customerService.Create(customer);
        }

        // PUT api/customers/5
        [HttpPut("{id}")]
        public ActionResult<Customer> Put(int id, Customer customer)
        {
            return _customerService.Update(customer);
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