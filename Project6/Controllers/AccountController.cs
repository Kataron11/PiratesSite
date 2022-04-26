using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project6.Model;
using Project6.Model.Validator;
using Project6.Models;
using Project6.Service;
using Project6.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Project6.Controllers
{
    [ApiController]
    [Route("/api/[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IValidator<AccountDto> _validator;

        public AccountController(IAccountService accountService, IValidator<AccountDto> validator)
        {
            _accountService = accountService;
            _validator = validator;
        }

        [HttpPost]
        public IActionResult CreateAccount([FromBody] AccountDto account)
        {

                var validateAccount = _validator.Validate(account);
            if (!validateAccount.IsValid)
                return BadRequest(validateAccount.Errors.Select(d => new { d.ErrorMessage, d.PropertyName }));

                _accountService.CreateAccount(account.Login, account.Password);

            return Ok(account);
        }

        [HttpPost]
        public IActionResult LoginAccount([FromBody] AccountLoginDto account)
        {
            Account logedAccount = _accountService.LoginAccount(account.Login, account.Password);
            if (logedAccount == null)
                return BadRequest();

            _accountService.UpdateLastLogin(logedAccount);

            return Ok(logedAccount);
        }
    }
}
