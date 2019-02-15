﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BankDbApi.Models;
using BankDbApi.Services;

namespace BankDbApi.Controllers
{
    [Route("api/accounts")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountsController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        
        [HttpPost]
        public ActionResult<Account> Post(Account account)
        {
            return _accountService.CreateAccount(account);
        }

        //by id
        [HttpGet("{id}")]
        public ActionResult<Account> Get(string IBAN)
        {
            return new JsonResult(_accountService.Read(IBAN));
        }


        // GET api/accounts
        [HttpGet]
        public ActionResult<List<Account>> GetAccounts()
        {
            return new JsonResult(_accountService.Read());
        }

        // DELETE api/accounts/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string IBAN)
        {
            _accountService.Delete(IBAN);
            return new NoContentResult();
        }
    }
}