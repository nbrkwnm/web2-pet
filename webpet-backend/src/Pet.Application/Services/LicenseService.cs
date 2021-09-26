using System.Collections.Generic;
using Pet.Application.Interfaces;
using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Models;

namespace Pet.Application.Services
{
    public class LicenseApplicationService : BaseApplicationService<License>, ILicenseApplicationService
    {
        public LicenseApplicationService(IBaseRepository<License> repository) : base(repository)
        {
        }
    }
}
