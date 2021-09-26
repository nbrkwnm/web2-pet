using Pet.Domain.Models;

namespace Pet.Infrastructure.Data.Repositories
{
    public class ServiceRepository : BaseRepository<Service>
    {
        private readonly AppDbContext _context;

        public ServiceRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
