using Pet.Domain.Models;

namespace Pet.Infrastructure.Data.Repositories
{
    public class AnimalRepository : BaseRepository<Animal>
    {
        private readonly AppDbContext _context;

        public AnimalRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }
}