using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ModelEntities.Repositories
{
    public interface IRepository<T> where T:class
    {
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetAllAsNoTracking();

        Task<IEnumerable<T>> Find(Expression<Func<T,bool>> predicate);
        Task<IEnumerable<T>> FindAsNoTracking(Expression<Func<T, bool>> predicate);

        Task Create(T item);

        Task<T> Get(int id);
    }
}
