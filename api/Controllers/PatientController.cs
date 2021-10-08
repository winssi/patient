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
    public class PatientController: ControllerBase
    {
        private readonly ILogger<PatientController> _logger;

        public PatientController(ILogger<PatientController> logger)
        {
            _logger = logger;
        }
        
        
        [HttpGet]
        [Route("liste")]
        public IActionResult GetPatients()
        {
            var db  = new PatientContext();
            if(db != null )
            {
                var patients = db.Patients
                .OrderBy(a => a.Id)
                .ToList();
            
                if(patients == null)
                {
                    return NoContent();
                }
                return Ok(patients);
            }            
            return NotFound("Pas de connexion");
        }
        
        [HttpGet]
        [Route("{id}")]
        public Patient GetPatientById(int id)
        {
            var db  = new PatientContext();
            var patient = db.Patients
                    .Where(a => a.Id == id)
                    .First();
            return patient;

        }

        [HttpPost]
        [Route("creation")]
        public IActionResult AddPatient(Patient patient)
        {
            var db  = new PatientContext();
            db.Add(patient);
            db.SaveChanges();
            return Ok(patient);

        }

        [HttpPut]
        [Route("modification")]
        public IActionResult Update(Patient patient)
        {
            var db  = new PatientContext();
            db.Patients.Update(patient);
            db.SaveChanges();
            return Ok(patient);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeletePatient(int id)
        {
            var db = new PatientContext();
            var patient = this.GetPatientById(id);
            if(patient == null)
            {
                return  NotFound();
            }
            db.Remove(patient);
            db.SaveChanges();
            return NoContent();
        }
    }
}