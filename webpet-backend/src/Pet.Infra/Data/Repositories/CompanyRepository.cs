using Pet.Domain.Models;

namespace Pet.Infrastructure.Data.Repositories
{
    public class CompanyRepository : BaseRepository<Company>
    {
        private readonly AppDbContext _context;

        public CompanyRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
