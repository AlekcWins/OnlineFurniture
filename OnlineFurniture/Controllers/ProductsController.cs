using Microsoft.AspNetCore.Mvc;
using OnlineFurniture.ProductsAdmin;
using Shop.Application.ProductsAdmin;
using Shop.Database;

namespace Shop.UI.Controllers
{
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        private ApplicationDbContext _ctx;

        public ProductsController(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        [HttpGet("products")]
        public IActionResult GetProducts() => Ok(new ProductService(_ctx).GetAllProducts());
        [HttpGet("products/(id)")]
        public IActionResult GetProduct(int id) => Ok(new ProductService(_ctx).GetSingleProduct(id));
        [HttpPost("products")]
        public IActionResult CreateProduct(ProductViewModel vm) => Ok(new ProductService(_ctx).CreateProduct(vm));
        [HttpDelete("products/(id)")]
        public IActionResult DeleteProduct(int id) => Ok(new ProductService(_ctx).DeleteProduct(id));
        [HttpPut("products")]
        public IActionResult UpdateProduct(ProductViewModel vm) => Ok(new ProductService(_ctx).UpdateProduct(vm));
        [HttpGet]
        public IActionResult GetSearchProduct(string search) => Ok(new ProductService(_ctx).GetSearchProduct(search));
        

    }
}
