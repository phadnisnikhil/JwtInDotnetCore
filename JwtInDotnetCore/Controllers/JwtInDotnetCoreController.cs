using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtInDotnetCore.Controllers
{
   //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    //This is to check API without token
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return ("Hello World");
        }
    }
}
