using Project6.Model;
using System.Linq;

namespace Project6.Repository.Interface
{
    public interface IShopRepository
    {
        public IQueryable<Boat> GetBoats();
    }
}
