using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BankDbApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionsController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        // GET api/transactions
        [HttpGet]
        public ActionResult<List<Transaction>> GetTransactions()
        {
            return new JsonResult(_transactionService.Read());
        }
    }
}
