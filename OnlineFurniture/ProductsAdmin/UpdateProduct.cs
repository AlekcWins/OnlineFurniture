using Shop.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.ProductsAdmin
{
    public class UpdateProduct
    {
        private ApplicationDbContext _context;
        public UpdateProduct(ApplicationDbContext context)
        {
            _context = context;
        }

     
        public async Task Do(ProductViewModel vm)
        {
 
            await _context.SaveChangesAsync();
        }
        
    }
}
