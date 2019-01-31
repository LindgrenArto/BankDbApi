using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankDbApi.Controllers
{
    [Route("api/banks")]
    [ApiController]
    public class BanksController : ControllerBase
    {
        private readonly IBankService _bankService;

        public BanksController(IBankService bankService)
        {
            _bankService = bankService;
        }

        // POST api/banks
        [HttpPost]
        public ActionResult<Bank> Post(Bank bank)
        {
            return _bank.Create(bank);
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