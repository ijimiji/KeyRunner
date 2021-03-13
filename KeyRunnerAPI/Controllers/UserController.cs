using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using KeyRunnerAPI.Models;
using System.Linq;
namespace KeyRunnerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        public ApplicationContext db;
        public UserController(ApplicationContext context)
        {
            db = context;
            db.AddRange(new User(), new User());
            db.SaveChanges();
        }

        [Route("Get")]
        public IActionResult Get()
        {
            return Ok(db.Users.ToList()[0]);
        }
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(db.Users.ToList());
        }
    }
}
