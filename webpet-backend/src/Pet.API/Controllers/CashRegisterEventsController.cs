using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pet.Application.Interfaces;
using Pet.Domain.Models;

namespace Pet.API.Controllers
{
    [Route("cashRegisterEvent")]
    [ApiController]
    public class CashRegisterEventsController : Controller
    {
        private readonly ICashRegisterEventApplicationService _applicationService;

        public CashRegisterEventsController(ICashRegisterEventApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<CashRegisterEvent>> Get()
        {
            return Ok(_applicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<CashRegisterEvent> Get(int id)
        {
            return Ok(_applicationService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] CashRegisterEvent cashRegisterEvent)
        {
            try
            {
                if (cashRegisterEvent == null)
                    return NotFound();
                
                _applicationService.Add(cashRegisterEvent);
                return Ok("CashRegisterEvent cadastrado com sucesso!");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] CashRegisterEvent cashRegisterEvent)
        {
            try
            {
                if (cashRegisterEvent == null)
                    return NotFound();
                
                _applicationService.Update(cashRegisterEvent);
                return Ok("CashRegisterEvent atualizado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] CashRegisterEvent cashRegisterEvent)
        {
            try
            {
                if (cashRegisterEvent == null)
                    return NotFound();
                
                _applicationService.Remove(cashRegisterEvent);
                return Ok("CashRegisterEvent removido com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
