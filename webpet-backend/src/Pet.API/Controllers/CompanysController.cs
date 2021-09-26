using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pet.Application.Interfaces;
using Pet.Domain.Models;

namespace Pet.API.Controllers
{
    [Route("company")]
    [ApiController]
    public class CompanysController : Controller
    {
        private readonly ICompanyApplicationService _applicationService;

        public CompanysController(ICompanyApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Company>> Get()
        {
            return Ok(_applicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Company> Get(int id)
        {
            return Ok(_applicationService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] Company company)
        {
            try
            {
                if (company == null)
                    return NotFound();
                
                _applicationService.Add(company);
                return Ok("Company cadastrado com sucesso!");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Company company)
        {
            try
            {
                if (company == null)
                    return NotFound();
                
                _applicationService.Update(company);
                return Ok("Company atualizado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] Company company)
        {
            try
            {
                if (company == null)
                    return NotFound();
                
                _applicationService.Remove(company);
                return Ok("Company removido com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
