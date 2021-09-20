using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pet.Application.Interfaces;
using Pet.Domain.Models;

namespace Pet.API.Controllers
{
    [Route("animal/")]
    [ApiController]
    public class AnimalsController : Controller
    {
        private readonly IAnimalApplicationService _applicationService;

        public AnimalsController(IAnimalApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] Animal animal)
        {
            try
            {
                if (animal == null)
                    return NotFound();
                
                _applicationService.Add(animal);
                return Ok("Animal cadastrado com sucesso!");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Animal animal)
        {
            try
            {
                if (animal == null)
                    return NotFound();
                
                _applicationService.Update(animal);
                return Ok("Animal atualizado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] Animal animal)
        {
            try
            {
                if (animal == null)
                    return NotFound();
                
                _applicationService.Remove(animal);
                return Ok("Animal removido com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}