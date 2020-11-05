

using System;
using System.Collections.Generic;
using OnlineFurniture.Domain.Model.Common;

namespace OnlineFurniture.Domain.Model
{
    /// <summary>
    /// Сущность - заказ товара
    /// </summary>
    public class Order
    {
        
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulfilled { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
