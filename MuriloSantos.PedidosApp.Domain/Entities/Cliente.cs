using System;

namespace MuriloSantos.PedidosApp.Domain.Entities
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
    }
}
