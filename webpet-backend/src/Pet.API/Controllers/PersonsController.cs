using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pet.Application.Dtos;
using Pet.Application.Interfaces;

namespace Pet.API.Controllers
{
    [Route("person/")]
    [ApiController]
    public class PersonsController : Controller
    {
        private readonly IPersonApplicationService _personApplicationService;

        public PersonsController(IPersonApplicationService personApplicationService)
        {
            _personApplicationService = personApplicationService;
        }
        
        // GET
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_personApplicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_personApplicationService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] PersonDto personDto)
        {
            try
            {
                if (personDto == null)
                    return NotFound();
                
                _personApplicationService.Add(personDto);
                return Ok("Pessoa cadastrada com sucesso!");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] PersonDto personDto)
        {
            try
            {
                if (personDto == null)
                    return NotFound();
                
                _personApplicationService.Update(personDto);
                return Ok("Pessoa atualizada com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] PersonDto personDto)
        {
            try
            {
                if (personDto == null)
                    return NotFound();
                
                _personApplicationService.Remove(personDto);
                return Ok("Pessoa removida com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}