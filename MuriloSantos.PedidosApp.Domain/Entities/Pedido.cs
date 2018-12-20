using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuriloSantos.PedidosApp.Domain.Entities
{
    public class Pedido
    {
        public Pedido()
        {
            Itens = new List<ItemPedido>();
        }

        public int NumeroPedido { get; set; }
        public DateTime DataEntrega { get; set; }
        public Guid ClienteId { get; set; }
        public decimal ValorTotal { get; private set; }
        public ICollection<ItemPedido> Itens { get; private set; }

        public ItemPedido AdicionarItem(Guid codigoProduto, int qtde, decimal valorUnitario)
        {
            var itemExistente = Itens.FirstOrDefault(i => i.ProdutoId == codigoProduto);
            if(itemExistente != null)
            {
                itemExistente.Quantidade += qtde;
                itemExistente.CalcularTotalItem();
                return itemExistente;
            }

            var novoItem = new ItemPedido
            {
                NumeroPedido = NumeroPedido,
                ProdutoId = codigoProduto,
                Quantidade = qtde,
                Valor = valorUnitario
            };

            Itens.Add(novoItem);
            novoItem.CalcularTotalItem();

            return novoItem;
        }

        public void CalcularTotal()
        {
            ValorTotal = Itens.Sum(i => i.ValorTotal);
        }

        public void RemoverItem(Guid codigoProduto)
        {
            Itens.Remove(Itens.FirstOrDefault(i => i.ProdutoId == codigoProduto));
        }
    }
}
