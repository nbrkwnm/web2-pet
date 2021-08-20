using System.Threading.Tasks;

namespace Pet.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}
