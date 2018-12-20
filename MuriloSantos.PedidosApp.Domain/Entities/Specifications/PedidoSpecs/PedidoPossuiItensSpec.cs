﻿using System;
using System.Linq.Expressions;

namespace MuriloSantos.PedidosApp.Domain.Entities.Specifications.PedidoSpecs
{
    public class PedidoPossuiItensSpec : Specification<Pedido>
    {
        public override Expression<Func<Pedido, bool>> ToExpression()
        {
            return pedido => pedido.Itens != null && pedido.Itens.Count > 0;
        }
    }
}
