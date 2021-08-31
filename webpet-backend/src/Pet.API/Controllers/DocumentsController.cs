using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pet.Application.Dtos;
using Pet.Application.Interfaces;

namespace Pet.API.Controllers
{
    [Route("document/")]
    [ApiController]
    public class DocumentsController : Controller
    {
        private readonly IDocumentApplicationService _documentApplicationService;

        public DocumentsController(IDocumentApplicationService documentApplicationService)
        {
            _documentApplicationService = documentApplicationService;
        }
        
        // GET
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_documentApplicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_documentApplicationService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] DocumentDto documentDto)
        {
            try
            {
                if (documentDto == null)
                    return NotFound();
                
                _documentApplicationService.Add(documentDto);
                return Ok("Documento cadastrado com sucesso!");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] DocumentDto documentDto)
        {
            try
            {
                if (documentDto == null)
                    return NotFound();
                
                _documentApplicationService.Update(documentDto);
                return Ok("Documento atualizado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] DocumentDto documentDto)
        {
            try
            {
                if (documentDto == null)
                    return NotFound();
                
                _documentApplicationService.Remove(documentDto);
                return Ok("Documento removido com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}