using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.v1;
using Persistence;

namespace Persistence
{
    public static class PersistenceDI
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HouseContext>(options => options.UseSqlite("Data Source=MyHouses.db"));

            // register implementations related to repository/generic implementation
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IHouseRepository, HouseRepository>();
        }
    }
}
