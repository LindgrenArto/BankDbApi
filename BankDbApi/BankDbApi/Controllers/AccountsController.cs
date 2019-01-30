using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankDbApi.Controllers
{
    [Route("api/accounts")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccount _account;

        public AccountsController(IAccount account)
        {
            _account = account;
        }

        // DELETE api/accounts/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _account.Delete(id);
            return new NoContentResult();
        }
    }
}