using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new[]
            {
                new { Id = 1, FName = "Iliyas", SName = "Ukenov" },
                new { Id = 2, FName ="Iliyas", SName = "Ukenov" },
                new { Id = 3, FName = "Iliyas", SName = "Ukenov" }
            };

            return Ok(users);
        }
    }
}
