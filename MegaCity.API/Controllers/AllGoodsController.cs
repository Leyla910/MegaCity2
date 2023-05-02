using MegaCity.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllGoodsController : ControllerBase
    {
        [HttpGet("All-Goods")]
        public IActionResult GetAllGoods()
        {
            List<GoodsOutputModel> allGoods = new List<GoodsOutputModel>
            {
                new GoodsOutputModel
                {
                    GoodsName = "goodsOne",
                    GoodsPrice = 12.6
                },

                new GoodsOutputModel
                {
                    GoodsName = "goodsTwo",
                    GoodsPrice = 19
                }
            };

            return Ok(allGoods);
        }
    }
}
