using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using MegaCity.API.Models;

namespace MegaCity.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllProductsController : ControllerBase
    {
        [HttpGet("products")]
        public IActionResult GetAllProducts()
        {
            List<ProductOutputModel> products = new List<ProductOutputModel>()
            {
                new ProductOutputModel()
                {
                    ProductName = "productOne",
                    ProductPrice = 100
                },

                new ProductOutputModel()
                {
                    ProductName = "productTwo",
                    ProductPrice = 200
                },

                new ProductOutputModel()
                {
                    ProductName = "productThree",
                    ProductPrice = 300
                }
            };

            return Ok(products);
        }
    }
}
