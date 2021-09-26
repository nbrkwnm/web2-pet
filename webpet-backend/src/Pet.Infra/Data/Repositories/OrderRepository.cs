using Pet.Domain.Models;

namespace Pet.Infrastructure.Data.Repositories
{
    public class OrderRepository : BaseRepository<Order>
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
