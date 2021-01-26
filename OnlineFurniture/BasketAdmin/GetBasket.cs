using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using OnlineFurniture.Domain.Model;
using Shop.Database;
using System.Collections.Generic;
using System.Linq;

namespace OnlineFurniture.BasketAdmin
{
    public class GetBasket
    {
        private ISession _session;
        private ApplicationDbContext _ctx;

        public GetBasket(ISession session, ApplicationDbContext ctx)
        {
            _session = session;
            _ctx = ctx;
        }

        public class Response
        {

            public Product Product { get; set; }

   
            public int Quantity { get; set; }
        }

        public IEnumerable<Response> Do()
        {
            var stringObject = _session.GetString("Basket");
            if(string.IsNullOrEmpty(stringObject))
            {
                return new List<Response>();
            }



            var BasketList = JsonConvert.DeserializeObject<List<Basket>>(stringObject);
            var response = _ctx.Products
                .Include(x => x.ProductId)
                .Where(x => BasketList.Any(y => y.Product.ProductId==x.ProductId))
                .Select(x => new Response
                {
                    Product = x,
                    Quantity=BasketList.FirstOrDefault(y => y.Product.ProductId == x.ProductId).Quantity,
                }).ToList();
            return response;
        }
    }
}
