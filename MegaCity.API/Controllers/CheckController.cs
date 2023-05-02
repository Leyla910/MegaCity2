using MegaCity.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MegaCity.API.Models;

namespace MegaCity.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckController : ControllerBase
    {

        [HttpGet("checks")]
        public IActionResult GetChecks()
        {
            List<CheckOutputModel> check_models = new List<CheckOutputModel>()
            {
                new CheckOutputModel()
                {
                    ProductName = "ProductOne",
                    ProductPrice = 17.10,
                    ProductCount = 10,
                    Sum = 171
                },

                new CheckOutputModel()
                {
                    ProductName = "ProductTwo",
                    ProductPrice = 12.50,
                    ProductCount = 15,
                    Sum = 187.50
                },
            };
            return Ok(check_models);
        }
    }
}
