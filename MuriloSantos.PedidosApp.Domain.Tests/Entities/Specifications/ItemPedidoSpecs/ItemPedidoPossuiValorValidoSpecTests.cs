using MuriloSantos.PedidosApp.Domain.Entities;
using MuriloSantos.PedidosApp.Domain.Entities.Specifications.ItemPedidoSpecs;
using NUnit.Framework;

namespace MuriloSantos.PedidosApp.Domain.Tests.Entities.Specifications.ItemPedidoSpecs
{
    public class ItemPedidoPossuiValorValidoSpecTests
    {
        [Test]
        public void ItemPedidoPossuiValorValidoSpec_Nao_Deve_Validar_Zero()
        {
            var itemPedido = new ItemPedido { Valor = 0 };
            var especificacao = new ItemPedidoPossuiValorValidoSpec();
            Assert.IsFalse(especificacao.IsSatisfiedBy(itemPedido));
        }

        [Test]
        public void ItemPedidoPossuiValorValidoSpec_Nao_Deve_Validar_Negativo()
        {
            var itemPedido = new ItemPedido { Valor = -0.01m };
            var especificacao = new ItemPedidoPossuiValorValidoSpec();
            Assert.IsFalse(especificacao.IsSatisfiedBy(itemPedido));
        }

        [Test]
        public void ItemPedidoPossuiValorValidoSpec_Deve_Validar_Positivo()
        {
            var itemPedido = new ItemPedido { Valor = 0.01m };
            var especificacao = new ItemPedidoPossuiValorValidoSpec();
            Assert.IsTrue(especificacao.IsSatisfiedBy(itemPedido));
        }
    }
}
