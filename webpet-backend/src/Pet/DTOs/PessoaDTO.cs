using System.ComponentModel.DataAnnotations;

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
