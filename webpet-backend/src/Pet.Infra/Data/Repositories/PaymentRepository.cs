using Pet.Domain.Models;

namespace Pet.Infrastructure.Data.Repositories
{
    public class PaymentRepository : BaseRepository<Payment>
    {
        private readonly AppDbContext _context;

        public PaymentRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
