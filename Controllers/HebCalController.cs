using Microsoft.AspNetCore.Mvc;
using RestSharp;
using DP;
namespace MyPersonalRecipeBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HebCalController
    {
        
            // GET: api/<HebCalController>
            [HttpGet]
            public List<string> Get()
            {
                string today = DateTime.Today.ToString("yyyy-MM-dd");
                string SevenDaysFromNow = DateTime.Today.AddDays(7).ToString("yyyy-MM-dd");
                BL.HebCalLogic bl = new BL.HebCalLogic();
                return bl.IsHolidyWeek(today, SevenDaysFromNow);
            }
  
    }
}
