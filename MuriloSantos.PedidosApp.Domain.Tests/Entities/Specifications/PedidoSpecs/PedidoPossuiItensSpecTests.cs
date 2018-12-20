using MuriloSantos.PedidosApp.Domain.Entities;
using MuriloSantos.PedidosApp.Domain.Entities.Specifications.PedidoSpecs;
using NUnit.Framework;
using System;

namespace MuriloSantos.PedidosApp.Domain.Tests.Entities.Specifications.PedidoSpecs
{
    public class PedidoPossuiItensSpecTests
    {
        [Test]
        public void PedidoPossuiItensSpec_Nao_Deve_Validar_Pedido_Sem_Item()
        {
            var pedido = new Pedido();
            var especificacao = new PedidoPossuiItensSpec();
            Assert.IsFalse(especificacao.IsSatisfiedBy(pedido));

            Guid codigoProduto = Guid.NewGuid();
            int qtde = 1;
            decimal valor = 5;

            pedido.AdicionarItem(codigoProduto, qtde, valor);
            pedido.RemoverItem(codigoProduto);

            Assert.IsFalse(especificacao.IsSatisfiedBy(pedido));
        }
    }
}
