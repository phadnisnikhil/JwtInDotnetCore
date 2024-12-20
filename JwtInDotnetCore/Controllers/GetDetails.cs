using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtInDotnetCore.Controllers
{
    [Authorize]

    [Route("api/[controller]")]
    [ApiController]
    public class GetDetails : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok("Account IFSC code is HDFC00000539");



        }
    }
}
