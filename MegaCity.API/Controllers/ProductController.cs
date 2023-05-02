using MegaCity.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("product")]
        public IActionResult GetProduct()
        {
            ProductOutputModel product = new ProductOutputModel()
            {
                ProductName = "Prouct",
                ProductPrice = 350
            };

            return Ok("product");
        }
    }
}
