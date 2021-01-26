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
        public IActionResult GetBasket() => Ok(new BasketService(,_ctx).GetBasket());
        [HttpPost]
        public IActionResult AddToBasket() => Ok(new BasketService(,_ctx).AddToBasket());
        public IActionResult DeleteFromBasket(int id) => Ok(new BasketService(,_ctx).DeleteFromBasket(id));
    }
    


}
