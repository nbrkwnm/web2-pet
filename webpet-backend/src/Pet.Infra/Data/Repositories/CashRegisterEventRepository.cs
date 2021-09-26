using Pet.Domain.Models;

namespace Pet.Infrastructure.Data.Repositories
{
    public class CashRegisterEventRepository : BaseRepository<CashRegisterEvent>
    {
        private readonly AppDbContext _context;

        public CashRegisterEventRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
