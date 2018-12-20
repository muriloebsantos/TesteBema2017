using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuriloSantos.PedidosApp.Domain.Entities
{
    public class ItemPedido
    {
        public int ItemPedidoId { get; set; }
        public int NumeroPedido { get; set; }
        public Guid ProdutoId { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorTotal { get; private set; }
        public virtual Pedido Pedido { get; set; }

        public void CalcularTotalItem()
        {
            ValorTotal = Quantidade * Valor;
        }
    }
}
