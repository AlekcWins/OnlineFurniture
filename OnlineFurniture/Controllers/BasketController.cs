using Microsoft.AspNetCore.Mvc;
using OnlineFurniture.BasketAdmin;
using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFurniture.Controllers
{
    [Route("[controller]")]
    public class BasketController : Controller
    {
        private ApplicationDbContext _ctx;
        public BasketController(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        public IActionResult GetBasket() => Ok(new GetBasket(,_ctx).Do());
        [HttpPost]
        public IActionResult AddToBasket() => Ok(new AddToBasket().Do());
    }
    


}
