using System.Collections.Generic;
using Pet.Domain.Models;

namespace Pet.Application.Interfaces
{
    public interface IUserApplicationService : IApplicationBaseService<User>
    {
        public IEnumerable<User> GetByName(string name);
    }
}
