using System;
using Microsoft.AspNetCore.Mvc;
using A5.Models;

namespace A5.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganisationController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetOrganisation([FromQuery] int count){
            Organisation[] organisations = {};
            return Ok(organisations);
        }
    }
}