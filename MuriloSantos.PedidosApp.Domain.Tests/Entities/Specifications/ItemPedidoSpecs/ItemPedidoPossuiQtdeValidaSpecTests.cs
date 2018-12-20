using MuriloSantos.PedidosApp.Domain.Entities;
using MuriloSantos.PedidosApp.Domain.Entities.Specifications.ItemPedidoSpecs;
using NUnit.Framework;

namespace MuriloSantos.PedidosApp.Domain.Tests.Entities.Specifications.ItemPedidoSpecs
{
    public class ItemPedidoPossuiQtdeValidaSpecTests
    {
        [Test]
        public void ItemPedidoPossuiQtdeValidaSpec_Nao_Deve_Validar_Zero()
        {
            var itemPedido = new ItemPedido { Quantidade = 0 };
            var especificao = new ItemPedidoPossuiQtdeValidaSpec();
            Assert.IsFalse(especificao.IsSatisfiedBy(itemPedido));
        }

        [Test]
        public void ItemPedidoPossuiQtdeValidaSpec_Nao_Deve_Validar_Negativo()
        {
            var itemPedido = new ItemPedido { Quantidade = -0.01m };
            var especificao = new ItemPedidoPossuiQtdeValidaSpec();
            Assert.IsFalse(especificao.IsSatisfiedBy(itemPedido));
        }

        [Test]
        public void ItemPedidoPossuiQtdeValidaSpec_Deve_Validar_ValorMinimo()
        {
            var itemPedido = new ItemPedido { Quantidade = 0.01m };
            var especificao = new ItemPedidoPossuiQtdeValidaSpec();
            Assert.IsTrue(especificao.IsSatisfiedBy(itemPedido));
        }

        [Test]
        public void ItemPedidoPossuiQtdeValidaSpec_Deve_Validar_ValorMaximo()
        {
            var itemPedido = new ItemPedido { Quantidade = 999.99m };
            var especificao = new ItemPedidoPossuiQtdeValidaSpec();
            Assert.IsTrue(especificao.IsSatisfiedBy(itemPedido));
        }

        [Test]
        public void ItemPedidoPossuiQtdeValidaSpec_Nao_Deve_Validar_ValorExcedido()
        {
            var itemPedido = new ItemPedido { Quantidade = 1000 };
            var especificao = new ItemPedidoPossuiQtdeValidaSpec();
            Assert.IsFalse(especificao.IsSatisfiedBy(itemPedido));
        }
    }
}
