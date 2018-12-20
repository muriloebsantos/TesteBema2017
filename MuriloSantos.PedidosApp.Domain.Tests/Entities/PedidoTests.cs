using MuriloSantos.PedidosApp.Domain.Entities;
using NUnit.Framework;
using System;
using System.Linq;

namespace MuriloSantos.PedidosApp.Domain.Tests.Entities
{
    public class PedidoTests
    {
        [Test]
        public void Pedido_Deve_Incluir_Item()
        {
            int numeroPedido = 100;

            var pedido = new Pedido
            {
                 NumeroPedido = numeroPedido
            };

            Guid codigoProduto = Guid.NewGuid();
            int qtde = 2;
            decimal valorUnitario = 1.25m;
            decimal valorTotal = qtde * valorUnitario;

            var novoItem = pedido.AdicionarItem(codigoProduto, qtde, valorUnitario);

            Assert.IsNotNull(novoItem);
            Assert.AreEqual(novoItem.NumeroPedido, numeroPedido);
            Assert.AreEqual(novoItem.ProdutoId, codigoProduto);
            Assert.AreEqual(novoItem.Valor, valorUnitario);
            Assert.AreEqual(novoItem.Quantidade, qtde);
            Assert.AreEqual(novoItem.ValorTotal, valorTotal);
            Assert.Contains(novoItem, pedido.Itens.ToList());
        }

        [Test]
        public void Pedido_Deve_Remover_Item()
        {
            var pedido = new Pedido();
            Guid codigoProduto = Guid.NewGuid();
            int qtde = 2;
            decimal valorUnitario = 1.25m;

            ItemPedido itemPedido = pedido.AdicionarItem(codigoProduto, qtde, valorUnitario);

            pedido.RemoverItem(codigoProduto);

            Assert.Zero(pedido.Itens.Count);
        }

        [Test]
        public void Pedido_Deve_Remover_Item_Correto()
        {
            var pedido = new Pedido();
            Guid codigoProduto = Guid.NewGuid();
            Guid codigoProduto2 = Guid.NewGuid();
            int qtde = 2;
            decimal valorUnitario = 1.25m;

            ItemPedido itemPedido1 = pedido.AdicionarItem(codigoProduto, qtde, valorUnitario);
            ItemPedido itemPedido2 = pedido.AdicionarItem(codigoProduto2, qtde, valorUnitario);

            pedido.RemoverItem(codigoProduto);

            Assert.IsTrue(pedido.Itens.Count == 1);
            Assert.IsFalse(pedido.Itens.Contains(itemPedido1));
        }

        [Test]
        public void Pedido_Deve_Calcular_Total()
        {
            var pedido = new Pedido();
            pedido.AdicionarItem(Guid.NewGuid(), 1, 10.50m);
            pedido.AdicionarItem(Guid.NewGuid(), 2, 3);
            pedido.CalcularTotal();

            decimal valorTotalEsperado = pedido.Itens.Sum(i => i.ValorTotal);

            Assert.AreEqual(valorTotalEsperado, pedido.ValorTotal);
        }
    }
}
