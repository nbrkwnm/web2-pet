using Pet.Domain.Models;

namespace Pet.Infrastructure.Data.Repositories
{
    public class ProductRepository : BaseRepository<Product>
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
