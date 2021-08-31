using System;
using System.Collections.Generic;

namespace Pet.Application.Dtos
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public IList<DocumentDto> Documents { get; set; }
    }
}