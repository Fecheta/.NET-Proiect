using Application.Interfaces;
using Domain.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.v1
{
    public class Repository : IHouseRepository
    {
        private readonly HouseContext context;

        public Repository(HouseContext context)
        {
            this.context = context;
        }
        public async Task<House> AddAsync(House entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<House> DeleteAsync(House entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(DeleteAsync)} entity mult not be null");
            }

            context.Remove(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<House>> GetAllAsync()
        {
            return await context.Set<House>().ToListAsync();
        }
        public async Task<House> GetByIdAsync(int id)
        {
            if (id is 0)
            {
                throw new ArgumentException($"{nameof(GetByIdAsync)} id must not be empty");
            }

            return await context.FindAsync<House>(id);
        }

        public async Task<House> GetByZipcodeAndBedrooms(string zipcode, string bedrooms)
        {
            var entity = await context.FindAsync<House>(zipcode, bedrooms);
            return entity;    
        }

        public async Task<House> UpdateAsync(House entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(UpdateAsync)} entity must not be null");
            }

            context.Update(entity);
            await context.SaveChangesAsync();
            return entity;
        }
    }
}
