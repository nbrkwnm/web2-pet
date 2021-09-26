using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pet.Application.Interfaces;
using Pet.Domain.Models;

namespace Pet.API.Controllers
{
    [Route("accommodation")]
    [ApiController]
    public class AccommodationsController : Controller
    {
        private readonly IAccommodationApplicationService _applicationService;

        public AccommodationsController(IAccommodationApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Accommodation>> Get()
        {
            return Ok(_applicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Accommodation> Get(int id)
        {
            return Ok(_applicationService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] Accommodation accommodation)
        {
            try
            {
                if (accommodation == null)
                    return NotFound();
                
                _applicationService.Add(accommodation);
                return Ok("Accommodation cadastrado com sucesso!");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Accommodation accommodation)
        {
            try
            {
                if (accommodation == null)
                    return NotFound();
                
                _applicationService.Update(accommodation);
                return Ok("Accommodation atualizado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] Accommodation accommodation)
        {
            try
            {
                if (accommodation == null)
                    return NotFound();
                
                _applicationService.Remove(accommodation);
                return Ok("Accommodation removido com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
