using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MuriloSantos.PedidosApp.Domain.Interfaces.Repositories
{
    public interface INoSqlRepository<T> where T : class
    {
        IEnumerable<T> All();

        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        T First(Expression<Func<T, bool>> predicate);

        long Count();

        void Insert(T entity);
    }
}
