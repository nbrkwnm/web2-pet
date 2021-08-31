using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Core.Interfaces.Services;
using Pet.Domain.Interfaces;
using Pet.Domain.Models;

namespace Pet.Domain.Services
{
    public class DocumentService : BaseService<Document>, IDocumentService
    {
        private readonly IDocumentRepository _repository;
        public DocumentService(IDocumentRepository repository) 
            : base(repository)
        {
            _repository = repository;
        }
    }
}