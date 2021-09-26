using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pet.Application.Interfaces;
using Pet.Domain.Models;

namespace Pet.API.Controllers
{
    [Route("occupant")]
    [ApiController]
    public class OccupantsController : Controller
    {
        private readonly IOccupantApplicationService _applicationService;

        public OccupantsController(IOccupantApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Occupant>> Get()
        {
            return Ok(_applicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Occupant> Get(int id)
        {
            return Ok(_applicationService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] Occupant occupant)
        {
            try
            {
                if (occupant == null)
                    return NotFound();
                
                _applicationService.Add(occupant);
                return Ok("Occupant cadastrado com sucesso!");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Occupant occupant)
        {
            try
            {
                if (occupant == null)
                    return NotFound();
                
                _applicationService.Update(occupant);
                return Ok("Occupant atualizado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] Occupant occupant)
        {
            try
            {
                if (occupant == null)
                    return NotFound();
                
                _applicationService.Remove(occupant);
                return Ok("Occupant removido com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
