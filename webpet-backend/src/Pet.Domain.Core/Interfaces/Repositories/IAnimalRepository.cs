using Pet.Domain.Models;

namespace Pet.Domain.Core.Interfaces.Repositories
{
    public interface IPetRepository : IBaseRepository<Animal>
    { }
}