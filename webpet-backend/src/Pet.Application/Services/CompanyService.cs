using System.Collections.Generic;
using Pet.Application.Interfaces;
using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Models;

namespace Pet.Application.Services
{
    public class CompanyApplicationService : BaseApplicationService<Company>, ICompanyApplicationService
    {
        public CompanyApplicationService(IBaseRepository<Company> repository) : base(repository)
        {
        }
    }
}
