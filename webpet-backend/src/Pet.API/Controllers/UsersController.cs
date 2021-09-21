using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pet.Application.Interfaces;
using Pet.Domain.Models;

namespace Pet.API.Controllers
{
    [Route("user/")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUserApplicationService _applicationService;

        public UsersController(IUserApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        
        // GET
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return Ok(_applicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            return Ok(_applicationService.GetById(id));
        }

        [HttpGet("{name}")]
        public ActionResult<IEnumerable<User>> GetByName(string name)
        {
            return Ok(_applicationService.GetByName(name));
        }

        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            try
            {
                if (user == null)
                    return NotFound();
                
                _applicationService.Add(user);
                return Ok("Usuário cadastrado com sucesso!");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] User user)
        {
            try
            {
                if (user == null)
                    return NotFound();
                
                _applicationService.Update(user);
                return Ok("Usuário atualizado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] User user)
        {
            try
            {
                if (user == null)
                    return NotFound();
                
                _applicationService.Remove(user);
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