using MuriloSantos.PedidosApp.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuriloSantos.PedidosApp.Application.Interfaces
{
    public interface IPedidoAppService
    {
        PedidoViewModel AdicionarItem(PedidoViewModel pedidoViewModel, Guid codigoProduto);

        PedidoViewModel RemoverItem(PedidoViewModel pedidoViewModel, Guid codigoProduto);

        ValidationResultViewModel GravarPedido(PedidoViewModel pedidoViewModel);

        KeyValuePair<long, List<PedidoViewModel>> ConsultarPedidos(ConsultaPedidoViewModel dadosPesquisa);
    }
}
