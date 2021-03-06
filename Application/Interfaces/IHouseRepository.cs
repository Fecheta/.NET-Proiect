using Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IHouseRepository : IRepository<House>
    {
        Task<House> GetByZipcodeAndBedrooms(string zipcode, string bedrooms);
    }
}
