using OnlineFurniture.Domain.Model.Common;

namespace OnlineFurniture.Domain.Model
{
    /// <summary>
    /// Сущность-корзина
    /// </summary>
    public class Basket : Entity
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
}
