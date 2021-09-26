using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pet.Application.Interfaces;
using Pet.Domain.Models;

namespace Pet.API.Controllers
{
    [Route("priceList")]
    [ApiController]
    public class PriceListsController : Controller
    {
        private readonly IPriceListApplicationService _applicationService;

        public PriceListsController(IPriceListApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<PriceList>> Get()
        {
            return Ok(_applicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<PriceList> Get(int id)
        {
            return Ok(_applicationService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] PriceList priceList)
        {
            try
            {
                if (priceList == null)
                    return NotFound();
                
                _applicationService.Add(priceList);
                return Ok("PriceList cadastrado com sucesso!");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] PriceList priceList)
        {
            try
            {
                if (priceList == null)
                    return NotFound();
                
                _applicationService.Update(priceList);
                return Ok("PriceList atualizado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] PriceList priceList)
        {
            try
            {
                if (priceList == null)
                    return NotFound();
                
                _applicationService.Remove(priceList);
                return Ok("PriceList removido com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
