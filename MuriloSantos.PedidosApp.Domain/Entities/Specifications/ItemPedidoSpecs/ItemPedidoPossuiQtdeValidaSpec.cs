using System;
using System.Linq.Expressions;

namespace MuriloSantos.PedidosApp.Domain.Entities.Specifications.ItemPedidoSpecs
{
    public class ItemPedidoPossuiQtdeValidaSpec : Specification<ItemPedido>
    {
        public override Expression<Func<ItemPedido, bool>> ToExpression()
        {
            return item => item.Quantidade > 0 && item.Quantidade <= 999.99m;
        }
    }
}
