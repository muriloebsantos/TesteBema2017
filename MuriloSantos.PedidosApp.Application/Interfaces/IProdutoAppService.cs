using MuriloSantos.PedidosApp.Application.ViewModels;
using System.Collections.Generic;

namespace MuriloSantos.PedidosApp.Application.Interfaces
{
    public interface IProdutoAppService
    {
        IEnumerable<ProdutoViewModel> ListarProdutos();
    }
}
