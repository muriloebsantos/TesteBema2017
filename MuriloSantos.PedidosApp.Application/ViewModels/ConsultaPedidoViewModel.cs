using System;

namespace MuriloSantos.PedidosApp.Application.ViewModels
{
    public class ConsultaPedidoViewModel
    {
        public Guid Cliente { get; set; }
        public int NumeroPedido { get; set; }
        public DateTime? DataInicialEntrega { get; set; }
        public DateTime? DataFinalEntrega { get; set; }
    }
}
