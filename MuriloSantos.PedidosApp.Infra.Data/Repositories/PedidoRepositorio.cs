using MuriloSantos.PedidosApp.Domain.Entities;
using MuriloSantos.PedidosApp.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace MuriloSantos.PedidosApp.Infra.Data.Repositories
{
    public class PedidoRepositorio : Repository<Pedido>, IPedidoRepositorio
    {
        public KeyValuePair<long, IEnumerable<Pedido>> ConsultaPaginada(System.Linq.Expressions.Expression<Func<Pedido, bool>> filtro, int paginaAtual, int qtdePorPagina, string campoOrdenacao)
        {
            var consulta = _context.Pedidos.Where(filtro);
            long qtdeRegistros = consulta.Count();

            switch (campoOrdenacao)
            {
                case "NumeroPedido":
                    consulta = consulta.OrderBy(c => c.NumeroPedido);
                    break;
                case "ValorTotal":
                    consulta = consulta.OrderBy(c => c.ValorTotal);
                    break;
            }

            int qtdeSkip = (paginaAtual - 1) * qtdePorPagina;

            consulta = consulta.Skip(qtdeSkip).Take(qtdePorPagina);

            var dados = consulta.ToList();

            return new KeyValuePair<long, IEnumerable<Pedido>>(qtdeRegistros, dados);
        }
    }
}
