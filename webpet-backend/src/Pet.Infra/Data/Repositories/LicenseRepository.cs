using Pet.Domain.Models;

namespace Pet.Infrastructure.Data.Repositories
{
    public class LicenseRepository : BaseRepository<License>
    {
        private readonly AppDbContext _context;

        public LicenseRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
