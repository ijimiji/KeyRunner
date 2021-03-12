using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using KeyRunnerAPI.Models;

namespace KeyRunnerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UserController : ControllerBase
    {
        private static List<User> users = new List<User> {
        new User(),
        new User { Id = 1, Name = "Sam"}
};
        [Route("Get")]
        public IActionResult Get()
        {
            return Ok(users[0]);
        }
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(users);
        }
    }
}
