using System;
using System.Linq.Expressions;

namespace MuriloSantos.PedidosApp.Domain.Entities.Specifications.ItemPedidoSpecs
{
    public class ItemPedidoPossuiValorValidoSpec : Specification<ItemPedido>
    {
        public override Expression<Func<ItemPedido, bool>> ToExpression()
        {
            return item => item.Valor > 0;
        }
    }
}
