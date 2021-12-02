using Application.Interfaces;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.v1
{
    public class HouseRepository : Repository, IHouseRepository
    {
        public HouseRepository(HouseContext context) : base(context)
        {
        }
    }
}
