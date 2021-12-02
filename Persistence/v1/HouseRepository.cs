using Application.Interfaces;
using Domain.Entities;
using Persistence.Context;
using System.Threading.Tasks;

namespace Persistence.v1
{
    public class HouseRepository : Repository<House>, IHouseRepository
    {
        private readonly HouseContext context;

        public HouseRepository(HouseContext context) : base(context)
        {
            this.context = context;
        }
        public async Task<House> GetByZipcodeAndBedrooms(string zipcode, string bedrooms)
        {
            var entity = await context.FindAsync<House>(zipcode, bedrooms);
            return entity;
        }
    }
}
