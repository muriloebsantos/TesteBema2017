using MuriloSantos.PedidosApp.Domain.Entities;
using System;
using MuriloSantos.PedidosApp.Domain.Interfaces.Repositories;

namespace MuriloSantos.PedidosApp.Infra.Data.Seeds
{
    public class ProdutoSeeder : ISeeder<Produto>
    {
        public void Seed(INoSqlRepository<Produto> repositorio)
        {
            repositorio.Insert(new Produto
            {
                Id = Guid.NewGuid(),
                Descricao = "iPhone 4s",
                Valor = 300
            });

            repositorio.Insert(new Produto
            {
                Id = Guid.NewGuid(),
                Descricao = "iPhone 5s",
                Valor = 800
            });

            repositorio.Insert(new Produto
            {
                Id = Guid.NewGuid(),
                Descricao = "iPhone SE",
                Valor = 1600
            });

            repositorio.Insert(new Produto
            {
                Id = Guid.NewGuid(),
                Descricao = "iPhone 6",
                Valor = 2500
            });

            repositorio.Insert(new Produto
            {
                Id = Guid.NewGuid(),
                Descricao = "Pilha AAA",
                Valor = 0.85m
            });
        }
    }
}
