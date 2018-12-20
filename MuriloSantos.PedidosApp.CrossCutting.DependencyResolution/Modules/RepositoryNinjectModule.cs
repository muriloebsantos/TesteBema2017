using MuriloSantos.PedidosApp.Domain.Interfaces.Repositories;
using MuriloSantos.PedidosApp.Infra.Data.Repositories;
using Ninject.Modules;

namespace MuriloSantos.PedidosApp.CrossCutting.DependencyResolution.Modules
{
    public class RepositoryNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(INoSqlRepository<>)).To(typeof(NoSqlRepository<>));
            Bind(typeof(IClienteRepositorio)).To(typeof(ClienteRepositorio));
            Bind(typeof(IProdutoRepositorio)).To(typeof(ProdutoRepositorio));
            Bind(typeof(IPedidoRepositorio)).To(typeof(PedidoRepositorio));
        }
    }
}
