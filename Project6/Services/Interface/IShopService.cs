
using Project6.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project6.Services.Interface
{
    public interface IShopService
    {
        public IQueryable<Boat> GetBoats();

    }
}
