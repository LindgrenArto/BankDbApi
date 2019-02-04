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
    [Route("api/bank")]
    [ApiController]
    public class BanksController : ControllerBase
    {
        private readonly IBankService _bankService;

        public BanksController(IBankService bankService)
        {
            _bankService = bankService;
        }

        [HttpGet]
        public ActionResult<List<Bank>> Get()
        {
            return new JsonResult(_bankService.Read());
        }

        // POST api/banks
        [HttpPost]
        public ActionResult<Bank> Post(Bank bank)
        {
            return _bankService.CreateBank(bank);
        }

        // PUT api/banks/5
        [HttpPut("{id}")]
        public ActionResult<Bank> Put(int id, Bank bank)
        {
            return _bankService.Update(id, bank);
        }

        // DELETE api/banks/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _bankService.Delete(id);
            return new NoContentResult();
        }
    }
}