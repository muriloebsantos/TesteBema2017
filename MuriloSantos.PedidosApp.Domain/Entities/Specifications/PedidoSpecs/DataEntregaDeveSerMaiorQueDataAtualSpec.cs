using System;
using System.Linq.Expressions;

namespace MuriloSantos.PedidosApp.Domain.Entities.Specifications.PedidoSpecs
{
    public class DataEntregaDeveSerMaiorQueDataAtualSpec : Specification<Pedido>
    {
        public override Expression<Func<Pedido, bool>> ToExpression()
        {
            return pedido => pedido.DataEntrega >= DateTime.Now.Date;
        }
    }
}
