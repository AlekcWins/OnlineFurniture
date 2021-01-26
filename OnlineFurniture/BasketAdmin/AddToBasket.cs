using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using OnlineFurniture.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace OnlineFurniture.BasketAdmin
{

    public class AddToBasket
    {
        private ISession _session;

        public AddToBasket(ISession session )
        {
            _session = session;
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

        public void Do(Request request)
        {
            var BasketList = new List<Basket>();
            var stringObject = _session.GetString("Basket");

            if(!string.IsNullOrEmpty(stringObject))
            {
                BasketList = JsonConvert.DeserializeObject<List<Basket>>(stringObject);
            }

            if(BasketList.Any(x => x.Product.ProductId == request.Product.ProductId))
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
        }
    }
}
