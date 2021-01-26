using Shop.Database;
using System.Linq;

namespace Shop.Application.ProductsAdmin
{
    public class GetProduct
    {
        private ApplicationDbContext _ctx;

        public GetProduct(ApplicationDbContext ctx)
        {
            _ctx = ctx; 
        }

        public ProductViewModel Do(int id)
        {
            return _ctx.Products.Where(x => x.ProductId == id).Select(x => new ProductViewModel
            {
                Id = x.ProductId,
                Name = x.Name,
                Description = x.Description,
                Value = x.Value,
                url_image = x.url_image,
            })
            .FirstOrDefault();
        }
    }

    }

