using Microsoft.EntityFrameworkCore;
using Project6.Model;
using Project6.Repository.Interface;
using System.Linq;

namespace Project6.Repository
{
    public class ShopRepository : IShopRepository
    {
        private readonly PirateDBContext _context;
        public ShopRepository(PirateDBContext context) => _context = context;

        public IQueryable<Boat> GetBoats()
        {
           return _context.Boat.AsNoTracking();
        }


    }
}
