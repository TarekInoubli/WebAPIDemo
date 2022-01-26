using HelloWorld.Service.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        //private readonly IDateTime _dateTime;

        //public HomeController(IDateTime dateTime)
        //{
        //    _dateTime = dateTime;
        //}

        [HttpGet(nameof(SayHallo))]
        public string SayHallo([FromServices] IDateTime _dateTime)
        {
            var serverTime = _dateTime.Now;
            if (serverTime.Hour < 12)
            {
                return "It's morning here - Good Morning!";
            }
            else if (serverTime.Hour < 17)
            {
                return "It's afternoon here - Good Afternoon!";
            }
            else
            {
                return "It's evening here - Good Evening!";
            }
        }
    }
}
