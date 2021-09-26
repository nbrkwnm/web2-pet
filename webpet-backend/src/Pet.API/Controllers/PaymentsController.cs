using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pet.Application.Interfaces;
using Pet.Domain.Models;

namespace Pet.API.Controllers
{
    [Route("payment")]
    [ApiController]
    public class PaymentsController : Controller
    {
        private readonly IPaymentApplicationService _applicationService;

        public PaymentsController(IPaymentApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Payment>> Get()
        {
            return Ok(_applicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Payment> Get(int id)
        {
            return Ok(_applicationService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] Payment payment)
        {
            try
            {
                if (payment == null)
                    return NotFound();
                
                _applicationService.Add(payment);
                return Ok("Payment cadastrado com sucesso!");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] Payment payment)
        {
            try
            {
                if (payment == null)
                    return NotFound();
                
                _applicationService.Update(payment);
                return Ok("Payment atualizado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] Payment payment)
        {
            try
            {
                if (payment == null)
                    return NotFound();
                
                _applicationService.Remove(payment);
                return Ok("Payment removido com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
