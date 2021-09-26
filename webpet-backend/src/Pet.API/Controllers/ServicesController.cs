using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pet.Application.Interfaces;
using Pet.Domain.Models;

namespace Pet.API.Controllers
{
    [Route("service")]
    [ApiController]
    public class ServicesController : Controller
    {
        private readonly IServiceApplicationService _applicationService;

        public ServicesController(IServiceApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Service>> Get()
        {
            return Ok(_applicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Service> Get(int id)
        {
            return Ok(_applicationService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] Service service)
        {
            try
            {
                if (service == null)
                    return NotFound();
                
                _applicationService.Add(service);
                return Ok("Service cadastrado com sucesso!");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Service service)
        {
            try
            {
                if (service == null)
                    return NotFound();
                
                _applicationService.Update(service);
                return Ok("Service atualizado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] Service service)
        {
            try
            {
                if (service == null)
                    return NotFound();
                
                _applicationService.Remove(service);
                return Ok("Service removido com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
