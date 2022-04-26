using Microsoft.AspNetCore.Mvc;
using Project6.Services.Interface;

namespace Project6.Controllers
{
    [ApiController]
    [Route("/api/[controller]/[action]")]
    public class ShopController : Controller
    {

        private readonly IShopService _shopService;

        public ShopController(IShopService shopService)
        {
            _shopService = shopService;
        }

        [HttpGet]
        public IActionResult GetBoats()
        {
            return Ok(_shopService.GetBoats());
        }

        /*private readonly IAccountService _accountService;
        private readonly IValidator<AccountDto> _validator;

        public AccountController(IAccountService accountService, IValidator<AccountDto> validator)
        {
            _accountService = accountService;
            _validator = validator;
        }*/

        
    }
}
