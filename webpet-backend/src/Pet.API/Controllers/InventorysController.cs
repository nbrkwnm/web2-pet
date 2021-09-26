using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pet.Application.Interfaces;
using Pet.Domain.Models;

namespace Pet.API.Controllers
{
    [Route("inventory")]
    [ApiController]
    public class InventorysController : Controller
    {
        private readonly IInventoryApplicationService _applicationService;

        public InventorysController(IInventoryApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Inventory>> Get()
        {
            return Ok(_applicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Inventory> Get(int id)
        {
            return Ok(_applicationService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] Inventory inventory)
        {
            try
            {
                if (inventory == null)
                    return NotFound();
                
                _applicationService.Add(inventory);
                return Ok("Inventory cadastrado com sucesso!");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Inventory inventory)
        {
            try
            {
                if (inventory == null)
                    return NotFound();
                
                _applicationService.Update(inventory);
                return Ok("Inventory atualizado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] Inventory inventory)
        {
            try
            {
                if (inventory == null)
                    return NotFound();
                
                _applicationService.Remove(inventory);
                return Ok("Inventory removido com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
