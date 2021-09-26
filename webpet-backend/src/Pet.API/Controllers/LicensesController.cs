using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pet.Application.Interfaces;
using Pet.Domain.Models;

namespace Pet.API.Controllers
{
    [Route("license")]
    [ApiController]
    public class LicensesController : Controller
    {
        private readonly ILicenseApplicationService _applicationService;

        public LicensesController(ILicenseApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<License>> Get()
        {
            return Ok(_applicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<License> Get(int id)
        {
            return Ok(_applicationService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] License license)
        {
            try
            {
                if (license == null)
                    return NotFound();
                
                _applicationService.Add(license);
                return Ok("License cadastrado com sucesso!");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] License license)
        {
            try
            {
                if (license == null)
                    return NotFound();
                
                _applicationService.Update(license);
                return Ok("License atualizado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] License license)
        {
            try
            {
                if (license == null)
                    return NotFound();
                
                _applicationService.Remove(license);
                return Ok("License removido com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
