using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineFurniture.BasketAdmin;
using OnlineFurniture.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineFurniture.Domain.DB;
using static OnlineFurniture.BasketAdmin.BasketService;

namespace OnlineFurniture.Controllers
{
    [Route("[controller]")]
    public class BasketController : Controller
    {
        private ApplicationDbContext _ctx;
        private ISession _session;
   

        public BasketController(ISession session, ApplicationDbContext ctx)
        {
            _ctx = ctx;
            _session = session;
        }
      
        

        [HttpGet]
        public IActionResult GetBasket() => Ok(new BasketService(_session, _ctx).GetBasket());
        [HttpPost]
        public IActionResult AddToBasket(Request request) => Ok(new BasketService(_session, _ctx).AddToBasket(request));
        [HttpDelete]
        public IActionResult DeleteFromBasket(int id) => Ok(new BasketService(_session, _ctx).DeleteFromBasket(id));
        [HttpGet]
        public IActionResult GetTotalPrice(int id) => Ok(new BasketService(_session, _ctx).GetTotalPrice());
        [HttpGet]
        public IActionResult GetTotalAmount(int id) => Ok(new BasketService(_session, _ctx).GetTotalAmount());
    }
    


}
