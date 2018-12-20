using MuriloSantos.PedidosApp.Domain.Interfaces.Repositories;
using MuriloSantos.PedidosApp.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuriloSantos.PedidosApp.Infra.Data.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly PedidosAppContext _context;

        public Repository()
        {
            _context = new PedidosAppContext();
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
    }
}
