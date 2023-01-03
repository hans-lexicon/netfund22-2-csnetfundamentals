using _00_Repetition.Models;
using _00_Repetition.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _00_Repetition.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }



        [HttpPost]
        public IActionResult Add(Product product)
        {
            _productService.AddToList(product);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            _productService.RemoveFromList(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _productService.Get(id);
            return Ok(product);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _productService.GetList();
            return Ok(list);
        }
    }
}
