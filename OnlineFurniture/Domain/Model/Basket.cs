using OnlineFurniture.Domain.Model.Common;

namespace OnlineFurniture.Domain.Model
{
    /// <summary>
    /// Сущность-корзина
    /// </summary>
    public class Basket : Entity
    {
        public int BasketId { get; set; }
        /// <summary>
        /// Товар, готовый к покупке
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Количество покупаемого товара
        /// </summary>
        public int Quantity { get; set; }
    }
}
