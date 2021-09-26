using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pet.Application.Interfaces;
using Pet.Domain.Models;

namespace Pet.API.Controllers
{
    [Route("hospitalization")]
    [ApiController]
    public class HospitalizationsController : Controller
    {
        private readonly IHospitalizationApplicationService _applicationService;

        public HospitalizationsController(IHospitalizationApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Hospitalization>> Get()
        {
            return Ok(_applicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Hospitalization> Get(int id)
        {
            return Ok(_applicationService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] Hospitalization hospitalization)
        {
            try
            {
                if (hospitalization == null)
                    return NotFound();
                
                _applicationService.Add(hospitalization);
                return Ok("Hospitalization cadastrado com sucesso!");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Hospitalization hospitalization)
        {
            try
            {
                if (hospitalization == null)
                    return NotFound();
                
                _applicationService.Update(hospitalization);
                return Ok("Hospitalization atualizado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] Hospitalization hospitalization)
        {
            try
            {
                if (hospitalization == null)
                    return NotFound();
                
                _applicationService.Remove(hospitalization);
                return Ok("Hospitalization removido com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
