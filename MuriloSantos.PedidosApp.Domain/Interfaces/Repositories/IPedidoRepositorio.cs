using MuriloSantos.PedidosApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MuriloSantos.PedidosApp.Domain.Interfaces.Repositories
{
    public interface IPedidoRepositorio : IRepository<Pedido>
    {
        KeyValuePair<long, IEnumerable<Pedido>> ConsultaPaginada(Expression<Func<Pedido, bool>> filtro, int paginaAtual, int qtdePorPagina, string campoOrdenacao);
    }
}
