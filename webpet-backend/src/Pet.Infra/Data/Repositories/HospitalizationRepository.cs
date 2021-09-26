using Pet.Domain.Models;

namespace Pet.Infrastructure.Data.Repositories
{
    public class HospitalizationRepository : BaseRepository<Hospitalization>
    {
        private readonly AppDbContext _context;

        public HospitalizationRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
