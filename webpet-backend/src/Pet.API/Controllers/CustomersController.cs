using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pet.Application.Interfaces;
using Pet.Domain.Models;

namespace Pet.API.Controllers
{
    [Route("customer/")]
    [ApiController]
    public class CustomersController : Controller
    {
        private readonly ICustomerApplicationService _applicationService;

        public CustomersController(ICustomerApplicationService applicationService)
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
        public ActionResult Post([FromBody] Customer customer)
        {
            try
            {
                if (customer == null)
                    return NotFound();
                
                _applicationService.Add(customer);
                return Ok("Usuário cadastrado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Customer customer)
        {
            try
            {
                if (customer == null)
                    return NotFound();
                
                _applicationService.Update(customer);
                return Ok("Usuário atualizado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] Customer customer)
        {
            try
            {
                if (customer == null)
                    return NotFound();
                
                _applicationService.Remove(customer);
                return Ok("Usuário removido com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}