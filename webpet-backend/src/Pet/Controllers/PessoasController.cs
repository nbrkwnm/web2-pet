using Microsoft.AspNetCore.Mvc;
using Pet.Domain.Interfaces;
using Pet.Domain.Models;
using System.Collections.Generic;

namespace Pet.Web.Controllers
{
    public class PessoasController : Controller
    {
        private readonly PessoaService _pessoaService;
        private readonly IRepository<Person> _pessoaRepository;

        public PessoasController(PessoaService pessoaService, IRepository<Person> pessoaRepository)
        {
            _pessoaService = pessoaService;
            _pessoaRepository = pessoaRepository;
        }

        [HttpGet]
        public IEnumerable<Person> GetPessoas()
        {
            var pessoas = _pessoaRepository.GetAll();
            return pessoas;
        }

        [HttpGet("{id}")]
        public Person GetPessoa(int id)
        {
            var pessoa = _pessoaRepository.GetById(id);

            return pessoa;
        }
    }
}
