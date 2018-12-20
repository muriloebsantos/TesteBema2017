using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using MuriloSantos.PedidosApp.Domain.Entities;
using MuriloSantos.PedidosApp.Domain.Interfaces.Repositories;
using MuriloSantos.PedidosApp.Infra.Data.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuriloSantos.PedidosApp.Infra.Data.Repositories
{
    public class ClienteRepositorio : NoSqlRepository<Cliente>, IClienteRepositorio
    {
        public ClienteRepositorio() : base("clientes")
        {

        }

        static ClienteRepositorio()
        {
            var repositorio = new ClienteRepositorio();

            if (repositorio.Count() > 0)
                return;

            new ClienteSeeder().Seed(repositorio);
        }
    }
}
