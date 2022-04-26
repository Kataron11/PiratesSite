
using Project6.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project6.Repository.Interface
{
    public interface IAccountRepository
    {
        IQueryable<Account> GetAccounts();
        Account GetAccount(string login, string password);
        public void AddAccount(Account account);
    }
}
