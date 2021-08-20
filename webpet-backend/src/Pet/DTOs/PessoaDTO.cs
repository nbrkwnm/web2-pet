using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pet.Web.DTOs
{
    public class PessoaDTO
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; private set; }
        [Required]
        public string Email { get; private set; }
    }
}
