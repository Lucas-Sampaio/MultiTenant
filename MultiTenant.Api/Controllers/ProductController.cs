using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultiTenant.Api.Data;
using MultiTenant.Api.Domain;
using System.Collections.Generic;
using System.Linq;

namespace MultiTenant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get([FromServices] ApplicationContext db)
        {
            var products = db.Products.ToArray();

            return products;
        }
    }
}
