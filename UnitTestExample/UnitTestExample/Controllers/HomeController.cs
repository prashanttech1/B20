using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UnitTestExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("index/{no}")]
        public string Index(int no)
        {
            if(no < 100)
            {
                return "Error ! its big no";
            }
            else if (no > 100)
            {
                return "Error ! its small no";
            }
            return "Correct no";

        }



    }
}
