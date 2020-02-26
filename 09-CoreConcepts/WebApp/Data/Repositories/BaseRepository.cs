using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data.Repositories
{

    public abstract class BaseRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext
    {
        private readonly DbContext context;
        
        public BaseRepository(TContext context)
        {
                        
            this.context = context;
        }

        public void Add(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<TEntity> AddAsync(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<TEntity> DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public TEntity Get(int id)
        {
            return this.context.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetAll()
        {
            return this.context.Set<TEntity>().AsNoTracking().ToList();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await this.context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetAsync(int id)
        {
            return await this.context.Set<TEntity>().FindAsync(id);
        }

        public void Update(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}