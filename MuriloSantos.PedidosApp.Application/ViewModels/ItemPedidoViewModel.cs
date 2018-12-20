using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuriloSantos.PedidosApp.Application.ViewModels
{
    public class ItemPedidoViewModel
    {
        public int NumeroPedido { get; set; }
        public Guid ProdutoId { get; set; }
        public string DescricaoProduto { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
