using System;
using Microsoft.AspNetCore.Mvc;
using A5.Models;
using A5.Data.Service;

namespace A5.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganisationController : ControllerBase
    {
        private readonly OrganisationService _organisationService;
        public OrganisationController(OrganisationService organisationService)
        {
            _organisationService = organisationService;
        } 

        [HttpGet("GetAll")]
        public ActionResult GetAllOrganisation()
        {
            var data = _organisationService.GetAll();
            return Ok(data);
        }

        [HttpGet("GetById")]
        public ActionResult GetByOrganisationId([FromQuery] int id)
        {
            var data = _organisationService.GetById(id);
            return Ok(data);
        }

        [HttpPost("Create")]
        public ActionResult Create(Organisation organisation)
        {
            var data = _organisationService.Create(organisation);
            if(data){
                return Ok();
            }
            return BadRequest();
        }
    }
}