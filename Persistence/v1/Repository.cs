using Application.Interfaces;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.v1
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly HouseContext context;

        public Repository(HouseContext context)
        {
            this.context = context;
        }

        public Task<TEntity> AddAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(entity)} entity must not be null");
            }

            return AddInternalAsync(entity);
        }

        public async Task<TEntity> AddInternalAsync(TEntity entity)
        {
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public Task<TEntity> DeleteAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(entity)} entity mult not be null");
            }

            return DeleteInternalAsync(entity);
        }

        public async Task<TEntity> DeleteInternalAsync(TEntity entity)
        {
            context.Remove(entity);
            await context.SaveChangesAsync();

            return entity;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await context.Set<TEntity>().ToListAsync();
        }

        public Task<TEntity> GetByIdAsync(int id)
        {
            if (id is 0)
            {
                throw new ArgumentException($"{nameof(id)} id must not be empty");
            }

            return GetByIdIntrenalAsync(id);
        }

        public async Task<TEntity> GetByIdIntrenalAsync(int id)
        {
            return await context.FindAsync<TEntity>(id);
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(entity)} entity must not be null");
            }

            return UpdateInternalAsync(entity);
        }

        public async Task<TEntity> UpdateInternalAsync(TEntity entity)
        {
            context.Update(entity);
            await context.SaveChangesAsync();
            return entity;
        }

    }
}
