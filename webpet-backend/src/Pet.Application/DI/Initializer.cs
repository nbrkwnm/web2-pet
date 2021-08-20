using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pet.Infra.Context;

namespace Pet.Application.DI
{
    public class Initializer
    {
        public static void Configure(IServiceCollection services, string connection)
        {
            services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connection));
        }
    }
}
