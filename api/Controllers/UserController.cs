using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace  Controller
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController: ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet]
        [Route("{id}")]
        public User GetUserById(int id)
        {
            var db  = new PatientContext();
            var user = db.Users
                    .Where(a => a.Id == id)
                    .First();
            return user;

        }

        [HttpPost]
        [Route("creation")]
        public IActionResult AddUser(User user)
        {
            var db  = new PatientContext();
            db.Add(user);
            db.SaveChanges();
            return Ok(user);
        }

    }
}