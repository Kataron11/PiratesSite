
using Project6.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project6.Services.Interface
{
    public interface IAccountService
    {
        public void CreateAccount(string login, string password);
        public Account LoginAccount(string login, string password);
        public void UpdateLastLogin(Account account);

    }
}
