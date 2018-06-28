using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace SchoolAPI.Repository
{
    public interface IRepository<T> where T : class
    {
        T Get(int i);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        void Add(T entity);
        void Remove(T entity);
    }
}
