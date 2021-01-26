using System.Collections.Generic;

namespace OnlineFurniture.Domain.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public string url_image { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }


    }
}