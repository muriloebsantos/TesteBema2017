using MuriloSantos.PedidosApp.Domain.Entities;
using MuriloSantos.PedidosApp.Domain.Entities.Specifications.PedidoSpecs;
using NUnit.Framework;
using System;

namespace MuriloSantos.PedidosApp.Domain.Tests.Entities.Specifications.PedidoSpecs
{
    public class ProdutosNaoSeRepetemSpecTests
    {
        [Test]
        public void ProdutosNaoSeRepetemSpec_Deve_Validar_Apenas_Um_Item()
        {
            var pedido = new Pedido();

            Guid codigoProduto = Guid.NewGuid();
            int qtde = 1;
            decimal valor = 5;

            pedido.AdicionarItem(codigoProduto, qtde, valor);

            var especificacao = new ProdutosNaoSeRepetemSpec();

            Assert.IsTrue(especificacao.IsSatisfiedBy(pedido));
        }

        [Test]
        public void ProdutosNaoSeRepetemSpec_Deve_Validar_Dois_Itens_Diferentes()
        {
            var pedido = new Pedido();

            Guid codigoProduto = Guid.NewGuid();
            Guid codigoProduto2 = Guid.NewGuid();
            int qtde = 1;
            decimal valor = 5;

            pedido.AdicionarItem(codigoProduto, qtde, valor);
            pedido.AdicionarItem(codigoProduto2, qtde, valor);

            var especificacao = new ProdutosNaoSeRepetemSpec();

            Assert.IsTrue(especificacao.IsSatisfiedBy(pedido));
        }
    }
}
