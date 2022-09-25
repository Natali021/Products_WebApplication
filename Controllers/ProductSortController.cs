using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products_WebApplication.Models;

namespace Products_WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSortController : ControllerBase
    {
        private static readonly List<Product> myProducts = new();
        private readonly ILogger<ProductController> _logger;
        public ProductSortController(ILogger<ProductController> logger)
        {
            myProducts.Add(new Product(1, "Goog1", 120, "Producer1", new DateTime(), "Сategory1"));
            myProducts.Add(new Product(2, "Goog22", 500, "Producer22", new DateTime(), "Сategory22"));
            myProducts.Add(new Product(3, "1Goog", 260, "1Producer", new DateTime(), "1Сategory"));
            myProducts.Add(new Product(4, "5Goog22", 1200, "5Producer22", new DateTime(), "5Сategory22"));
            _logger = logger;
        }


        [HttpGet(Name = "GetProductSort")]
        public IEnumerable<Product> Get()
        {            
            return myProducts.OrderBy(x => x.Price).ToList();
        }
    }
}
