using Microsoft.AspNetCore.Mvc;

namespace dapr.microservice.webapi2.Controllers
{
    [ApiController]
    public class SaluteController : ControllerBase
    {
        [HttpGet("salute")]
        public ActionResult<string> Get()
        {
            Console.WriteLine("Salute, World.");
            return "Salute, World";
        }
    }
}
