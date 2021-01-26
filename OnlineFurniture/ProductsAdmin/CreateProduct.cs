using OnlineFurniture.Domain.Model;
using Shop.Database;
using Shop.Domain.Models;
using System.Threading.Tasks;

namespace Shop.Application.ProductsAdmin
{
    public class CreateProduct
    {
        private ApplicationDbContext _context;
        public CreateProduct(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Do(ProductViewModel vm)
        {
            _context.Products.Add(new Product 
            {
                Name=vm.Name,
                Description=vm.Description,
                Value=vm.Value,
                url_image = vm.url_image,
            });
            await _context.SaveChangesAsync();
        }
       
    }
}
