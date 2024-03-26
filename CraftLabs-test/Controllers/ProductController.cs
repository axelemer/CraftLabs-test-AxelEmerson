using CraftLabs.Implementations.Contracts.Contracts;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CraftLabs_test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productService.GetAll());
        }

        [HttpGet("/discount")]
        public IActionResult GetDiscountedProducts()
        {
            return Ok(_productService.GetDiscountedProducts());
        }
    }
}
