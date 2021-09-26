using Pet.Domain.Models;

namespace Pet.Infrastructure.Data.Repositories
{
    public class OrderItemRepository : BaseRepository<OrderItem>
    {
        private readonly AppDbContext _context;

        public OrderItemRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
