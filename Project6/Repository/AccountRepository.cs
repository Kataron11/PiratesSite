using Microsoft.EntityFrameworkCore;
using Project6.Model;
using Project6.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project6.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly PirateDBContext _context;
        public AccountRepository(PirateDBContext context) => _context = context;

        public IQueryable<Account> GetAccounts()
        {
            return _context.Account.AsNoTracking();
        }
        public Account GetAccount(string login, string password)
        {
            return _context.Account.Where(d => d.Login == login && d.Password == password).FirstOrDefault();
        }

        public void AddAccount(Account account)
        {
            _context.Add<Account>(account);
            _context.SaveChanges();
        }
    }
}
