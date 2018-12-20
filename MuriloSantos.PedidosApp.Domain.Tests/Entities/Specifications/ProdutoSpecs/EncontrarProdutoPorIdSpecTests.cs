using MuriloSantos.PedidosApp.Domain.Entities;
using MuriloSantos.PedidosApp.Domain.Entities.Specifications.ProdutoSpecs;
using NUnit.Framework;
using System;

namespace MuriloSantos.PedidosApp.Domain.Tests.Entities.Specifications.ProdutoSpecs
{
    public class EncontrarProdutoPorIdSpecTests
    {
        [Test]
        public void EncontrarProdutoPorIdSpec_Nao_Deve_Satisfazer()
        {
            var produto = new Produto { Id = Guid.NewGuid() };
            var novoGuid = Guid.NewGuid();
            var especificacao = new EncontrarProdutoPorIdSpec(novoGuid);
            Assert.IsFalse(especificacao.IsSatisfiedBy(produto));
        }

        [Test]
        public void EncontrarProdutoPorIdSpec_Deve_Satisfazer()
        {
            var produto = new Produto { Id = Guid.NewGuid() };
            var novoGuid = new Guid(produto.Id.ToString());
            var especificacao = new EncontrarProdutoPorIdSpec(novoGuid);
            Assert.IsTrue(especificacao.IsSatisfiedBy(produto));
        }
    }
}
