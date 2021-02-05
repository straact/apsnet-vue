using Microsoft.AspNetCore.Mvc;

namespace TrakingLibrary.API.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class Home : ControllerBase
    {
        // Documentation
        [HttpGet]
        public string Index()
        {
            return "Hello a Home Controller";
        }
    }
}