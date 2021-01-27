using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OnlineFurniture.Controllers;
using OnlineFurniture.Domain.DB;
using OnlineFurniture.ProductsAdmin;
using Shop.Application.ProductsAdmin;

namespace Shop.UI.Controllers
{
    [Route("api")]
    public class ProductsController : Controller
    {
        private ApplicationDbContext _ctx;

        public ProductsController(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet("products")]
        public IActionResult GetProducts()
        {
            IEnumerable<ProductViewModel> products = new ProductService(_ctx).GetAllProducts();
            return  Ok(new ServerResponseProducts {count = 10 , products = products });
        } 
        

        [HttpGet("products/{id}")]
        public IActionResult GetProduct(int id) => Ok(new ProductService(_ctx).GetSingleProduct(id));


        [HttpPost("products")]
        public IActionResult CreateProduct([FromBody] ProductViewModel vm) 

        {
            new ProductService(_ctx).CreateProduct(vm);
            return Ok();
        }


        [HttpDelete("products/(id)")]
        public IActionResult DeleteProduct(int id) => Ok(new ProductService(_ctx).DeleteProduct(id));


        [HttpPut("products")]
        public IActionResult UpdateProduct(ProductViewModel vm) => Ok(new ProductService(_ctx).UpdateProduct(vm));


        [HttpGet]
        public IActionResult GetSearchProduct(string search) => Ok(new ProductService(_ctx).GetSearchProduct(search));
    }
}