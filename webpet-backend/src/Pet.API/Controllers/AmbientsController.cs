using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pet.Application.Interfaces;
using Pet.Domain.Models;

namespace Pet.API.Controllers
{
    [Route("ambient")]
    [ApiController]
    public class AmbientsController : Controller
    {
        private readonly IAmbientApplicationService _applicationService;

        public AmbientsController(IAmbientApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Ambient>> Get()
        {
            return Ok(_applicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Ambient> Get(int id)
        {
            return Ok(_applicationService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] Ambient ambient)
        {
            try
            {
                if (ambient == null)
                    return NotFound();
                
                _applicationService.Add(ambient);
                return Ok("Ambient cadastrado com sucesso!");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Ambient ambient)
        {
            try
            {
                if (ambient == null)
                    return NotFound();
                
                _applicationService.Update(ambient);
                return Ok("Ambient atualizado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] Ambient ambient)
        {
            try
            {
                if (ambient == null)
                    return NotFound();
                
                _applicationService.Remove(ambient);
                return Ok("Ambient removido com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
