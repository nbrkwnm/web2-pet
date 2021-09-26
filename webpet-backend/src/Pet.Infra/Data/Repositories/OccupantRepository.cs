using Pet.Domain.Models;

namespace Pet.Infrastructure.Data.Repositories
{
    public class OccupantRepository : BaseRepository<Occupant>
    {
        private readonly AppDbContext _context;

        public OccupantRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
