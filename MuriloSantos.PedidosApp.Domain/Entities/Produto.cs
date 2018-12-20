using System;

namespace MuriloSantos.PedidosApp.Domain.Entities
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}
