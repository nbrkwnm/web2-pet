using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pet.Application.Dtos;
using Pet.Application.Interfaces;

namespace Pet.API.Controllers
{
    [Route("user/")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUserApplicationService _userApplicationService;

        public UsersController(IUserApplicationService userApplicationService)
        {
            _userApplicationService = userApplicationService;
        }
        
        // GET
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_userApplicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_userApplicationService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] UserDto userDto)
        {
            try
            {
                if (userDto == null)
                    return NotFound();
                
                _userApplicationService.Add(userDto);
                return Ok("Usuário cadastrado com sucesso!");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] UserDto userDto)
        {
            try
            {
                if (userDto == null)
                    return NotFound();
                
                _userApplicationService.Update(userDto);
                return Ok("Usuário atualizado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] UserDto userDto)
        {
            try
            {
                if (userDto == null)
                    return NotFound();
                
                _userApplicationService.Remove(userDto);
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