using Pet.Domain.Models;

namespace Pet.Infrastructure.Data.Repositories
{
    public class AccommodationRepository : BaseRepository<Accommodation>
    {
        private readonly AppDbContext _context;

        public AccommodationRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
