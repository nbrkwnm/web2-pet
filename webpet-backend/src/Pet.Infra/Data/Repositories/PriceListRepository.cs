using Pet.Domain.Models;

namespace Pet.Infrastructure.Data.Repositories
{
    public class PriceListRepository : BaseRepository<PriceList>
    {
        private readonly AppDbContext _context;

        public PriceListRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
