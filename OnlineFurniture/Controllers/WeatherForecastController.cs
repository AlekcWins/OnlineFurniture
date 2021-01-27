﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        [Route("products")]
        public Resp Get()
        {
            var products = new List<Product>();
            products.Add(new Product {Id = 1, Name = "laptop"});
            return new Resp(){ count = 8, products = products};
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Images { get; set; }
    }

    public class Resp
    {
        public int count { get; set; }
        public List<Product> products { get; set; }
    }
}