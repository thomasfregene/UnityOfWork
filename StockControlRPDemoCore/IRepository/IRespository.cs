using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StockControlRPDemoCore.IRepository
{
    public interface IRespository<TEntity, TKey> where TEntity : class
    {
        Task<TEntity> Get(TKey Id);
        IEnumerable<TEntity> GetAll();
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);
        Task<bool> Add(TEntity entity);
        Task<int> AddRange(IEnumerable<TEntity> entities);
        Task<bool> Update(TKey Id, TEntity entity);
        Task<long> Count();
        bool Remove(TEntity entity);
        Task<int> RemoveRange(IEnumerable<TEntity> entities);
    }
}
