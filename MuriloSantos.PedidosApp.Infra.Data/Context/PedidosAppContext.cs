using MuriloSantos.PedidosApp.Domain.Entities;
using MuriloSantos.PedidosApp.Infra.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuriloSantos.PedidosApp.Infra.Data.Context
{
    public class PedidosAppContext : DbContext
    {
        static PedidosAppContext()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<PedidosAppContext>());
        }

        public PedidosAppContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PedidoMapping());
            modelBuilder.Configurations.Add(new ItemPedidoMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
