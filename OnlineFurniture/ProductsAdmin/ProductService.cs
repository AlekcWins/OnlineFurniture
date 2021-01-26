using OnlineFurniture.Domain.Model;
using Shop.Application.ProductsAdmin;
using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFurniture.ProductsAdmin
{
    public class ProductService 
    {
        private ApplicationDbContext _ctx;
        public ProductService(ApplicationDbContext context)
        {
            _ctx = context;
        }

        public async Task UpdateProduct(ProductViewModel vm)
        {

            await _ctx.SaveChangesAsync();
        }
        public IEnumerable<ProductViewModel> GetAllProducts()
        {
            return _ctx.Products.ToList().Select(x => new ProductViewModel
            {
                Id = x.ProductId,
                Name = x.Name,
                Description = x.Description,
                Value = x.Value,
                url_image = x.url_image,
            });
        }
        public ProductViewModel GetSingleProduct(int id)
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

        public async Task CreateProduct(ProductViewModel vm)
        {
            _ctx.Products.Add(new Product
            {
                Name = vm.Name,
                Description = vm.Description,
                Value = vm.Value,
                url_image = vm.url_image,
            });
            await _ctx.SaveChangesAsync();
        }

        public async Task DeleteProduct(int id)
        {
            var Product = _ctx.Products.FirstOrDefault(x => x.ProductId == id);
            _ctx.Products.Remove(Product);
            await _ctx.SaveChangesAsync();
        }

    }
}
