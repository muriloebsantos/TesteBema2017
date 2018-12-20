using MuriloSantos.PedidosApp.Domain.Interfaces.Specification;
using System;
using System.Linq.Expressions;

namespace MuriloSantos.PedidosApp.Domain.Entities.Specifications
{
    public abstract class Specification<T> : ISpecification<T> where T : class
    {
        public abstract Expression<Func<T, bool>> ToExpression();

        public bool IsSatisfiedBy(T entity)
        {
            Func<T, bool> predicado = ToExpression().Compile();
            return predicado(entity);
        }
    }
}
