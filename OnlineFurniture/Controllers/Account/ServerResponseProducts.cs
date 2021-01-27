using System.Collections.Generic;
using OnlineFurniture.Domain.Model;
using Shop.Application.ProductsAdmin;

namespace OnlineFurniture.Controllers
{
    public class ServerResponseProducts
    {
        public int count { get; set; }
        public IEnumerable<ProductViewModel> products { get; set; }
    }
}