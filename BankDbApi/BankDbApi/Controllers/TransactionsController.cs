using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankDbApi.Models;
using BankDbApi.Services;

namespace BankDbApi.Controllers
{
    [Route("api/transactions")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionsController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }


        //BY ID
        [HttpGet("{id}")]
        public ActionResult<Transaction> GetTransactions(int id)
        {
            return new JsonResult(_transactionService.Read(id));
        }

        // GET api/transactions
        [HttpGet]
        public ActionResult<List<Transaction>> GetTransactions()
        {
            return new JsonResult(_transactionService.Read());
        }

        // POST api/transactions
        [HttpPost]
        public ActionResult<Transaction> Post(Transaction transaction)
        {
            return _transactionService.CreateTransaction(transaction);
        }
    }
}
