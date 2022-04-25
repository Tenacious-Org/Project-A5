using System;
using Microsoft.AspNetCore.Mvc;
using A5API.Models;

namespace A5API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        
        [HttpGet]
        public ActionResult GetEmployees([FromQuery] int count){
            Employee[] employees = {
                new(){ Fname = "Aakash"}, new(){ Fname = "Ajay"},
                new(){ Fname = "Aravinth"}, new(){ Fname = "Archana"},
                new(){ Fname = "Atsaya"}, new(){ Fname = "Jeeva"},
                new(){ Fname = "Karthik"}, new(){ Fname = "Loki"},
                new(){ Fname = "Madhu"}, new(){ Fname = "Priya"},
            };
            if(!employees.Any())
                return NotFound();
            return Ok(employees.Take(count));
        }
   }
}