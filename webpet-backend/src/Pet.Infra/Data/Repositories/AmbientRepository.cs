using Pet.Domain.Models;

namespace Pet.Infrastructure.Data.Repositories
{
    public class AmbientRepository : BaseRepository<Ambient>
    {
        private readonly AppDbContext _context;

        public AmbientRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
