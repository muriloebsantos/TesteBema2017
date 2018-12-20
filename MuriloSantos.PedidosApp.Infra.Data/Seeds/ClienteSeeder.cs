using MuriloSantos.PedidosApp.Domain.Entities;
using MuriloSantos.PedidosApp.Domain.Interfaces.Repositories;
using System;

namespace MuriloSantos.PedidosApp.Infra.Data.Seeds
{
    public class ClienteSeeder : ISeeder<Cliente>
    {
        public void Seed(INoSqlRepository<Cliente> repositorio)
        {
            repositorio.Insert(new Cliente
            {
                Id = Guid.NewGuid(),
                Nome = "Murilo Eduardo Bacagini Santos",
                Cpf = "400.127.108-73"
            });

            repositorio.Insert(new Cliente
            {
                Id = Guid.NewGuid(),
                Nome = "João Carlos da Silva",
                Cpf = "782.878.341-80"
            });

            repositorio.Insert(new Cliente
            {
                Id = Guid.NewGuid(),
                Nome = "Maria Aparecida Santos",
                Cpf = "758.263.501-99"
            });

            repositorio.Insert(new Cliente
            {
                Id = Guid.NewGuid(),
                Nome = "Carlos José Oliveira",
                Cpf = "154.267.772-68"
            });
        }
    }
}
