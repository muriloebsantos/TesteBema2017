using System;

namespace MuriloSantos.PedidosApp.Application.ViewModels
{
    public class ProdutoViewModel
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}
