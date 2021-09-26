using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pet.Application.Interfaces;
using Pet.Domain.Models;

namespace Pet.API.Controllers
{
    [Route("order")]
    [ApiController]
    public class OrdersController : Controller
    {
        private readonly IOrderApplicationService _applicationService;

        public OrdersController(IOrderApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Order>> Get()
        {
            return Ok(_applicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
            return Ok(_applicationService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] Order order)
        {
            try
            {
                if (order == null)
                    return NotFound();
                
                _applicationService.Add(order);
                return Ok("Order cadastrado com sucesso!");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Order order)
        {
            try
            {
                if (order == null)
                    return NotFound();
                
                _applicationService.Update(order);
                return Ok("Order atualizado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] Order order)
        {
            try
            {
                if (order == null)
                    return NotFound();
                
                _applicationService.Remove(order);
                return Ok("Order removido com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
