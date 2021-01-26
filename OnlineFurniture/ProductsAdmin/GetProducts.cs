using Shop.Database;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Application.ProductsAdmin
{
    public class GetProducts
    {
        private ApplicationDbContext _ctx;

        public GetProducts(ApplicationDbContext ctx)
        {
            _ctx = ctx; 
        }

        public IEnumerable<ProductViewModel> Do()
        {
            return _ctx.Products.ToList().Select(x => new ProductViewModel
            {
                Id= x.ProductId,
                Name=x.Name,
                Description = x.Description,
                Value = x.Value,
                url_image = x.url_image,
            });
        }
    }

}
