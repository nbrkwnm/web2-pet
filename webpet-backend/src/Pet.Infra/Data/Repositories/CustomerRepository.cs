using Pet.Domain.Models;

namespace Pet.Infrastructure.Data.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>
    {
        private readonly AppDbContext _context;

        public CustomerRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }
}