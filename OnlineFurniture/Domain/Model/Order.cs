using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineFurniture.Domain.Model
{
    public class Order
    {
 
        public int OrderId { get; set; }
        public string OrderRef { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
