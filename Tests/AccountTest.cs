using FluentValidation;
using Moq;
using NUnit.Framework;
using Project6.Controllers;
using Project6.Model;
using Project6.Models;
using Project6.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class AccountTest
    {
        //private Mock<IUnitOfWork> _unitOfWork;
        //private Mock<ILogger<UserController>> _logger;
        private Mock<IAccountService> _accountService;
        private Mock<IValidator<AccountDto>> _validator;
        private AccountController _accountController;

        [SetUp]
        public void SetUp()
        {
            _accountService = new Mock<IAccountService>();
            _validator = new Mock<IValidator<AccountDto>>();
            _accountController = new AccountController(
                 _accountService.Object,
                 _validator.Object
                );
        }

        [TestCase("LoginTest","PasswordTest")]
        [Test]
        public void TestLogin(string login, string password)
        {
            AccountLoginDto loginDto = new AccountLoginDto()
            {
                Login = login,
                Password = password
            }
            ;
            var result = _accountController.LoginAccount(loginDto);
            Assert.IsNotNull(result);

        }
    }
}
