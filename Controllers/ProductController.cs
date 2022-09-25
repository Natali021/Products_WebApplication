using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products_WebApplication.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using Microsoft.Extensions.Logging;

namespace Products_WebApplication.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static readonly List<Product> myProducts = new();
        private readonly ILogger<ProductController> _logger;
        public ProductController(ILogger<ProductController> logger)
        {            
            myProducts.Add(new Product(1, "Goog1", 120, "Producer1", new DateTime(), "Сategory1"));
            myProducts.Add(new Product(2, "Goog22", 500, "Producer22", new DateTime(), "Сategory22"));
            myProducts.Add(new Product(3, "1Goog", 260, "1Producer", new DateTime(), "1Сategory"));
            myProducts.Add(new Product(4, "5Goog22", 1200, "5Producer22", new DateTime(), "5Сategory22"));
            _logger = logger;
        }
        

        [HttpGet(Name = "GetProduct")]
        public IEnumerable<Product> Get()
        {
            return myProducts;            
        }
    }
}
