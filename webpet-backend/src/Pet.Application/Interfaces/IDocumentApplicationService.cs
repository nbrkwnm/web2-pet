using System.Collections.Generic;
using Pet.Application.Dtos;

namespace Pet.Application.Interfaces
{
    public interface IDocumentApplicationService
    {
        void Add(DocumentDto documentDto);
        void Update(DocumentDto documentDto);
        void Remove(DocumentDto documentDto);
        IEnumerable<DocumentDto> GetAll();
        DocumentDto GetById(int id);
    }
}