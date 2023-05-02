using MegaCity.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsController : ControllerBase
    {

        [HttpGet("goods")]
        public IActionResult GetGoods()
        {
            GoodsOutputModel goods = new GoodsOutputModel()
            {
                GoodsName = "Potato",
                GoodsPrice = 17
            };

            return Ok("goods");
        }
    }
}