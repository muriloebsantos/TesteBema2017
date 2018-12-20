using MuriloSantos.PedidosApp.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MuriloSantos.PedidosApp.Infra.Data.Mapping
{
    public class PedidoMapping : EntityTypeConfiguration<Pedido>
    {
        public PedidoMapping()
        {
            ToTable("tbPedido");
            HasKey(a => a.NumeroPedido);
            Property(a => a.NumeroPedido).HasColumnName("ped_numero");
            Property(a => a.DataEntrega).HasColumnName("ped_dataEntrega").HasColumnType("date");
            Property(a => a.ClienteId).HasColumnName("cli_codigo");
            Property(a => a.ValorTotal).HasColumnName("ped_valorTotal").HasPrecision(18, 2);
        }
    }
}
