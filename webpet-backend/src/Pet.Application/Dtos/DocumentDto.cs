using Pet.Domain.Enum;

namespace Pet.Application.Dtos
{
    public class DocumentDto
    {
        public int Id { get; set; }
        public DocumentType Type { get; set; }
        public string Number { get; set; }
    }
}