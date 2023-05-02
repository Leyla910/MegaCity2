using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Components.Forms;
using MegaCity.API.Models;

namespace MegaCity.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet("order")]
        public IActionResult GetOrders()
        {
            List<OrderOutputModel> order = new List<OrderOutputModel>()
            {
                new OrderOutputModel()
                {
                    ProductName = "product",
                    ProductCount = 21
                },

                new OrderOutputModel()
                {
                    ProductName = "productTwo",
                    ProductCount = 37
                }
            };

            return Ok(order);
        }
    }
}