using Project6.Model;
using Project6.Repository.Interface;
using Project6.Services.Interface;
using System.Linq;

namespace Project6.Services
{
    public class ShopService : IShopService
    {
        readonly IShopRepository _shopRepository;  

        public ShopService(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository; 
        }

        public IQueryable<Boat> GetBoats()
        {
            return _shopRepository.GetBoats();
        }

    }
}
