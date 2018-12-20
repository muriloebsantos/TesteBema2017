using MuriloSantos.PedidosApp.Application;
using MuriloSantos.PedidosApp.Application.Interfaces;
using Ninject.Modules;

namespace MuriloSantos.PedidosApp.CrossCutting.DependencyResolution.Modules
{
    public class ApplicationNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IClienteAppService)).To(typeof(ClienteAppService));
            Bind(typeof(IProdutoAppService)).To(typeof(ProdutoAppService));
            Bind(typeof(IPedidoAppService)).To(typeof(PedidoAppService));
        }
    }
}
