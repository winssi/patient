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
        [Route("{email}")]
        public UserP GetUserByEmail(string Email)
        {
            var db  = new PatientContext();
            var userpatient = db.UserPs
                    .Where(a => a.Email == Email)
                    .First();
            return userpatient;
        }


        [HttpGet]
        [Route("{id}")]
        public UserP GetUserById(int id)
        {
            var db  = new PatientContext();
            var userpatient = db.UserPs
                    .Where(a => a.Id == id)
                    .First();
            return userpatient;

        }

        [HttpPost]
        [Route("creation")]
        public IActionResult Register(UserP userpatient)
        {
            var db = new PatientContext();
            var mail = userpatient.Email;
            var verifmail = this.GetUserByEmail(mail);
            if(verifmail != null)
            {
                return Ok("ce compte existe déjà");
            }
            db.Add(userpatient);
            db.SaveChanges();
            return Ok();

        }

    }
}