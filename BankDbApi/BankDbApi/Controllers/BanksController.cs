using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankDbApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BanksController : ControllerBase
    {
        private readonly IBank _bank;

        public BanksController(IBank bank)
        {
            _bank = bank;
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
            return _bank.Update(bank);
        }

        // DELETE api/banks/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _bank.Delete(id);
            return new NoContentResult();
        }
    }
}