using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using OnlineFurniture.Domain.Model;
using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            public string Name { get; set; }
            public string Value { get; set; }
            public int ProductId { get; set; }

   
            public int Quantity { get; set; }
        }

        public Response Do()
        {
            var stringObject = _session.GetString("Basket");
            var BasketProduct = JsonConvert.DeserializeObject<Basket>(stringObject);
            var response = _ctx.Products
                .Include(x => x.ProductId)
                .Where(x => x.ProductId == BasketProduct.ProductId)
                .Select(x => new Response
                {
                    Name = x.Name,
                    Value =$"${ x.Value.ToString("N2")}",
                    ProductId = x.ProductId,
                    Quantity=BasketProduct.Quantity,
                }).FirstOrDefault();
            return response;
        }
    }
}
