using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using OnlineFurniture.Domain.Model;
using OnlineFurniture.Domain.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFurniture.BasketAdmin
{
    public class BasketService
    {
        private ISession _session;
        private ApplicationDbContext _ctx;

        public BasketService(ISession session, ApplicationDbContext ctx)
        {
            _session = session;
            _ctx = ctx;
        }
        public class Request
        {
            /// <summary>
            /// Товар, готовый к покупке
            /// </summary>
            public Product Product { get; set; }

            /// <summary>
            /// Количество покупаемого товара
            /// </summary>
            public int Quantity { get; set; }
        }
        public object AddToBasket(Request request)
        {
            var BasketList = new List<Basket>();
            var stringObject = _session.GetString("Basket");

            if (!string.IsNullOrEmpty(stringObject))
            {
                BasketList = JsonConvert.DeserializeObject<List<Basket>>(stringObject);
            }

            if (BasketList.Any(x => x.Product.ProductId == request.Product.ProductId))
            {
                BasketList.Find(x => x.Product.ProductId == request.Product.ProductId).Quantity += request.Quantity;
            }
            else
            {
                BasketList.Add(new Basket
                {
                    Product = request.Product,
                    Quantity = request.Quantity,
                });
            }

            stringObject = JsonConvert.SerializeObject(request);
            _session.SetString("Basket", stringObject);
            return null;
        }
        public IEnumerable<Request> GetBasket()
        {
            var stringObject = _session.GetString("Basket");
            if (string.IsNullOrEmpty(stringObject))
            {
                return new List<Request>();
            }



            var BasketList = JsonConvert.DeserializeObject<List<Basket>>(stringObject);
            var response = _ctx.Products
                .Include(x => x.ProductId)
                .Where(x => BasketList.Any(y => y.Product.ProductId == x.ProductId))
                .Select(x => new Request
                {
                    Product = x,
                    Quantity = BasketList.FirstOrDefault(y => y.Product.ProductId == x.ProductId).Quantity,
                }).ToList();
            return response;
        }
        public async Task DeleteFromBasket(int id)
        {
            var Basket = _ctx.Basket.FirstOrDefault(x => x.Product.ProductId == id);
            _ctx.Basket.Remove(Basket);
            await _ctx.SaveChangesAsync();
        }
        public decimal GetTotalPrice()
        {
            var stringObject = _session.GetString("Basket");
            if (string.IsNullOrEmpty(stringObject))
            {
                return 0;
            }

            decimal price = 0;

            var BasketList = JsonConvert.DeserializeObject<List<Basket>>(stringObject);
            foreach (var item in BasketList)
            {
                price += item.Product.Value;
            }
                
            return price;
        }
        public int GetTotalAmount()
        {
            var stringObject = _session.GetString("Basket");
            if (string.IsNullOrEmpty(stringObject))
            {
                return 0;
            }

            int amount = 0;

            var BasketList = JsonConvert.DeserializeObject<List<Basket>>(stringObject);
            foreach (var item in BasketList)
            {
                amount += item.Quantity;
            }

            return amount;
        }

    }
}
