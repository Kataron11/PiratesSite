using Microsoft.EntityFrameworkCore;
using Project6.Model;
using Project6.Repository.Interface;
using Project6.Services.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Project6.Service
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
       /* private readonly ISurveyRepository _surveyRepository;
        private readonly IMailService _mailService;
        private readonly IFileService _fileService;
        private readonly AuthenticationSettings _authenticationSettings;
        private readonly TwilioAccountSettings _twilioAccont;
        private readonly IPasswordHasher<Users> _passwordHasher;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;*/

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public void CreateAccount(string login, string password)
        {
            Account account = new Account();
            account.Login = login;
            account.Password = password;

            _accountRepository.AddAccount(account);
        }

        public Account LoginAccount(string login, string password)
        {
            return _accountRepository.GetAccount(login, password);
        }

        public void UpdateLastLogin(Account account)
        {
            account.LastLogin = System.DateTime.Now;
        }

    }
}
