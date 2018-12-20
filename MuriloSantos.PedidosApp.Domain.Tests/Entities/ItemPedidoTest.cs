using MuriloSantos.PedidosApp.Domain.Entities;
using NUnit.Framework;

namespace MuriloSantos.PedidosApp.Domain.Tests.Entities
{
    public class ItemPedidoTest
    {
        [Test]
        public void ItemPedido_Deve_Calcular_Total_Item()
        {
            var itemPedido = new ItemPedido
            {
                Quantidade = 2,
                Valor = 7.25m
            };

            itemPedido.CalcularTotalItem();

            decimal valorEsperado = itemPedido.Quantidade * itemPedido.Valor;
            decimal valorReal = itemPedido.ValorTotal;

            Assert.AreEqual(valorEsperado, valorReal);
        }
    }
}
