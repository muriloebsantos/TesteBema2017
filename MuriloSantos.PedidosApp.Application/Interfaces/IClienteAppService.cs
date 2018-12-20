using MuriloSantos.PedidosApp.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuriloSantos.PedidosApp.Application.Interfaces
{
    public interface IClienteAppService
    {
        IEnumerable<ClienteViewModel> ListarClientes();
    }
}
