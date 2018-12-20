using MuriloSantos.PedidosApp.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MuriloSantos.PedidosApp.Infra.Data.Mapping
{
    public class ItemPedidoMapping : EntityTypeConfiguration<ItemPedido>
    {
        public ItemPedidoMapping()
        {
            ToTable("tbPedidoItem");
            HasKey(a => a.ItemPedidoId);
            HasRequired(a => a.Pedido).WithMany(b => b.Itens).HasForeignKey(c => c.NumeroPedido);
            Property(a => a.ItemPedidoId).HasColumnName("item_id");
            Property(a => a.NumeroPedido).HasColumnName("ped_numero");
            Property(a => a.ProdutoId).HasColumnName("pro_codigo");
            Property(a => a.Quantidade).HasColumnName("item_quantidade").HasPrecision(5, 2);
            Property(a => a.Valor).HasColumnName("item_valor").HasPrecision(18, 2);
            Property(a => a.ValorTotal).HasColumnName("item_total").HasPrecision(18, 2);
        }
    }
}
