using Microsoft.AspNetCore.Mvc;
using KeyRunnerAPI.Models;

namespace KeyRunnerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UserController : ControllerBase
    {
        private static User user = new User();
        [Route("Get")]
        public IActionResult Get()
        {
            return Ok(user);
        }
    }
}
