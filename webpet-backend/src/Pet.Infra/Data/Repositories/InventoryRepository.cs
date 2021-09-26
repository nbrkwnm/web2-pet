using Pet.Domain.Models;

namespace Pet.Infrastructure.Data.Repositories
{
    public class InventoryRepository : BaseRepository<Inventory>
    {
        private readonly AppDbContext _context;

        public InventoryRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
