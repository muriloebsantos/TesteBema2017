using MuriloSantos.PedidosApp.Domain.Entities;
using MuriloSantos.PedidosApp.Domain.Entities.Specifications.PedidoSpecs;
using NUnit.Framework;
using System;

namespace MuriloSantos.PedidosApp.Domain.Tests.Entities.Specifications.PedidoSpecs
{
    public class DataEntregaDeveSerMaiorQueDataAtualSpecTests
    {
        [Test]
        public void DataEntregaDeveSerMaiorQueDataAtual_Deve_Validar_Data_Atual()
        {
            var pedido = new Pedido
            {
                DataEntrega = DateTime.Now
            };

            var especificao = new DataEntregaDeveSerMaiorQueDataAtualSpec();

            Assert.IsTrue(especificao.IsSatisfiedBy(pedido));
        }

        [Test]
        public void DataEntregaDeveSerMaiorQueDataAtual_Deve_Validar_Data_Futura()
        {
            var pedido = new Pedido
            {
                DataEntrega = DateTime.Now.AddDays(1)
            };

            var especificao = new DataEntregaDeveSerMaiorQueDataAtualSpec();

            Assert.IsTrue(especificao.IsSatisfiedBy(pedido));
        }

        [Test]
        public void DataEntregaDeveSerMaiorQueDataAtual_Nao_Deve_Validar_Data_Passada()
        {
            var pedido = new Pedido
            {
                DataEntrega = DateTime.Now.AddDays(-1)
            };

            var especificao = new DataEntregaDeveSerMaiorQueDataAtualSpec();

            Assert.IsFalse(especificao.IsSatisfiedBy(pedido));
        }
    }
}
