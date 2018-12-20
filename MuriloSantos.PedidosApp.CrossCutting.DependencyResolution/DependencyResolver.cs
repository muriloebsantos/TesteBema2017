using CommonServiceLocator.NinjectAdapter.Unofficial;
using Microsoft.Practices.ServiceLocation;
using MuriloSantos.PedidosApp.CrossCutting.DependencyResolution.Modules;
using Ninject;

namespace MuriloSantos.PedidosApp.CrossCutting.DependencyResolution
{
    public class DependencyResolver
    {
        public IKernel Kernel { get; private set; }

        public DependencyResolver()
        {
            Kernel = GetNinjectModules();
            ServiceLocator.SetLocatorProvider(() => new NinjectServiceLocator(Kernel));
        }

        public StandardKernel GetNinjectModules()
        {
            return new StandardKernel(
                new RepositoryNinjectModule(),
                new ApplicationNinjectModule(),
                new DomainServicesNinjectModule()
                );
        }

    }
}
