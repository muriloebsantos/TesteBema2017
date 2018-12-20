using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MuriloSantos.PedidosApp.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Insert(T entity);
    }
}
