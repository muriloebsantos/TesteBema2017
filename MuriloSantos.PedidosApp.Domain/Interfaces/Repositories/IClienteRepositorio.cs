using MuriloSantos.PedidosApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuriloSantos.PedidosApp.Domain.Interfaces.Repositories
{
    public interface IClienteRepositorio : INoSqlRepository<Cliente>
    {
    }
}
