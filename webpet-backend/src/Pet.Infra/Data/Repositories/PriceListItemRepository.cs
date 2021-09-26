using Pet.Domain.Models;

namespace Pet.Infrastructure.Data.Repositories
{
    public class PriceListItemRepository : BaseRepository<PriceListItem>
    {
        private readonly AppDbContext _context;

        public PriceListItemRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
