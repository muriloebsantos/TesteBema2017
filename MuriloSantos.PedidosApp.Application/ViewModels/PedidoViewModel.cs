using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuriloSantos.PedidosApp.Application.ViewModels
{
    public class PedidoViewModel
    {
        public PedidoViewModel() { }
        public int NumeroPedido { get; set; }
        public DateTime DataEntrega { get; set; }
        public Guid ClienteId { get; set; }
        public decimal ValorTotal { get; set; }
        public ICollection<ItemPedidoViewModel> Itens { get;  set; }
    }
}
