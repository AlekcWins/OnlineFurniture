using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using OnlineFurniture.Domain.Model;

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
            public int ProductId { get; set; }

            /// <summary>
            /// Количество покупаемого товара
            /// </summary>
            public int Quantity { get; set; }
        }

        public void Do(Request request)
        {
            var BasketProduct = new Basket
            {
                ProductId = request.ProductId,
                Quantity = request.Quantity,
            };
            var stringObject = JsonConvert.SerializeObject(request);
            _session.SetString("Basket", stringObject);
        }
    }
}
