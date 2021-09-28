using Microsoft.EntityFrameworkCore;
using StockControlRPDemoCore.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StockControlRPDemoCore.Repository
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class
    {
        private readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }

        public async Task<bool> Add(TEntity entity)
        {
            await Context.Set<TEntity>().AddAsync(entity);
            return true;
        }

        public async Task<int> AddRange(IEnumerable<TEntity> entities)
        {
            await Context.Set<TEntity>().AddRangeAsync(entities);
            return entities.Count();
        }

       
        public async Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return await Context.Set<TEntity>().Where(predicate).ToListAsync();
        }

        //why virtual
        public async virtual Task<TEntity> Get(TKey Id)
        {
            return await Context.Set<TEntity>().FindAsync(Id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().AsEnumerable();
        }

        public bool Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
            return true;
        }

        public int RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
            return entities.Count();
        }

        public async Task<bool> Update(TKey Id, TEntity entity)
        {
            TEntity existingEntity = await Context.Set<TEntity>().FindAsync(Id);
            Context.Entry(existingEntity).CurrentValues.SetValues(entity);
            return true;
        }

        public async Task<long> Count()
        {
            return await Context.Set<TEntity>().CountAsync();
        }

    }
}
