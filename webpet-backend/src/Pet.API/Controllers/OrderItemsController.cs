using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pet.Application.Interfaces;
using Pet.Domain.Models;

namespace Pet.API.Controllers
{
    [Route("orderItem")]
    [ApiController]
    public class OrderItemsController : Controller
    {
        private readonly IOrderItemApplicationService _applicationService;

        public OrderItemsController(IOrderItemApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<OrderItem>> Get()
        {
            return Ok(_applicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<OrderItem> Get(int id)
        {
            return Ok(_applicationService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] OrderItem orderItem)
        {
            try
            {
                if (orderItem == null)
                    return NotFound();
                
                _applicationService.Add(orderItem);
                return Ok("OrderItem cadastrado com sucesso!");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] OrderItem orderItem)
        {
            try
            {
                if (orderItem == null)
                    return NotFound();
                
                _applicationService.Update(orderItem);
                return Ok("OrderItem atualizado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] OrderItem orderItem)
        {
            try
            {
                if (orderItem == null)
                    return NotFound();
                
                _applicationService.Remove(orderItem);
                return Ok("OrderItem removido com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
