

using OnlineFurniture.Domain.Model.Common;

namespace OnlineFurniture.Domain.Model
{
    /// <summary>
    /// Сущность - заказ товара
    /// </summary>
    public class Order : Entity
    {
        /// <summary>
        /// Список заказа
        /// </summary>
        public Basket Basket { get; set; }

        /// <summary>
        /// Заказчик
        /// </summary>
        public User User { get; set; }
    }
}
