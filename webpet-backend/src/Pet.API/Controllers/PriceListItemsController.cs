using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pet.Application.Interfaces;
using Pet.Domain.Models;

namespace Pet.API.Controllers
{
    [Route("priceListItem")]
    [ApiController]
    public class PriceListItemsController : Controller
    {
        private readonly IPriceListItemApplicationService _applicationService;

        public PriceListItemsController(IPriceListItemApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<PriceListItem>> Get()
        {
            return Ok(_applicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<PriceListItem> Get(int id)
        {
            return Ok(_applicationService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] PriceListItem priceListItem)
        {
            try
            {
                if (priceListItem == null)
                    return NotFound();
                
                _applicationService.Add(priceListItem);
                return Ok("PriceListItem cadastrado com sucesso!");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] PriceListItem priceListItem)
        {
            try
            {
                if (priceListItem == null)
                    return NotFound();
                
                _applicationService.Update(priceListItem);
                return Ok("PriceListItem atualizado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] PriceListItem priceListItem)
        {
            try
            {
                if (priceListItem == null)
                    return NotFound();
                
                _applicationService.Remove(priceListItem);
                return Ok("PriceListItem removido com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
