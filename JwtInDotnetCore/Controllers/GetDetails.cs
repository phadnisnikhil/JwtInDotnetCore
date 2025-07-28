using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtInDotnetCore.Controllers
{
    [Authorize]

  //[Authorize(Roles = "Admin")]

    [Route("api/[controller]")]
    [ApiController]
    public class GetDetails : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok("Account IFSC code is HDFC00000539");
        }
        [HttpGet("GetAccountHolder")]
        public IActionResult GetAccountHolder()
        {
            return Ok("Nikhil Milind Phadnis");
        }

    }
    public class A {
        public void method() { }

    }
    public class B : A { 
     
        A obj = new A();
        public void method1()
        {
            B obk = new B();
            obj.method();
            obk.method();
        }

    }
}
