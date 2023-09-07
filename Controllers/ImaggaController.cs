using Microsoft.AspNetCore.Mvc;

namespace MyPersonalRecipeBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImaggaController
    {
        // GET: api/<ImaggaController>
        [HttpGet]
        public string Get(string title, string imageURL, string tag)
        {
            BL.ImaggaLogic bl = new BL.ImaggaLogic();
            DP.ImaggaParamsDTO dp = new DP.ImaggaParamsDTO { Title = title, ImageUrl = imageURL, Tag = tag };
            return bl.IsGoodPic(dp);
        }
    }
}
