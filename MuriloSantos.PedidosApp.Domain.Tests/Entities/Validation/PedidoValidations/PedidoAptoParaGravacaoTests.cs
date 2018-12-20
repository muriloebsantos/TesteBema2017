using MuriloSantos.PedidosApp.Domain.Entities;
using MuriloSantos.PedidosApp.Domain.Entities.Validations.PedidoValidations;
using MuriloSantos.PedidosApp.Domain.Messages;
using MuriloSantos.PedidosApp.Domain.Validation;
using NUnit.Framework;
using System;
using System.Linq;

namespace MuriloSantos.PedidosApp.Domain.Tests.Entities.Validation.PedidoValidations
{
    public class PedidoAptoParaGravacaoTests
    {
        [Test]
        public void PedidoAptoParaGravacao_Nao_Deve_Aceitar_Data_Invalida()
        {
            var pedido = new Pedido { DataEntrega = DateTime.Now.AddDays(-1) };
            ValidationResult validacao = new PedidoAptoParaGravacao().Valid(pedido);
            Assert.IsTrue(validacao.Errors.Any(e => e.Message == ValidationMessages.Pedido_Data_Deve_Ser_Maior_Que_Atual));
        }

        [Test]
        public void PedidoAptoParaGravacao_Deve_Exigir_Itens()
        {
            var pedido = new Pedido();
            ValidationResult validacao = new PedidoAptoParaGravacao().Valid(pedido);
            Assert.IsTrue(validacao.Errors.Any(e => e.Message == ValidationMessages.Pedido_Deve_Possuir_Itens));
        }

        [Test]
        public void PedidoAptoParaGravacao_Deve_Validar_Pedido()
        {
            var pedido = new Pedido
            {
                 DataEntrega = DateTime.Now.AddDays(1)
            };

            Guid codigoProduto = Guid.NewGuid();
            int qtde = 2;
            decimal valorUnitario = 1.25m;

            pedido.AdicionarItem(codigoProduto, qtde, valorUnitario);

            ValidationResult validacao = new PedidoAptoParaGravacao().Valid(pedido);
            Assert.IsTrue(validacao.IsValid);
        }
    }
}
