using System.Threading.Tasks;

namespace Pet.Domain.Core.Interfaces.Services
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}
