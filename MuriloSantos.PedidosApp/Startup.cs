using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using MuriloSantos.PedidosApp.Application.Interfaces;
using MuriloSantos.PedidosApp.Domain.Entities;
using Ninject;

[assembly: OwinStartup(typeof(MuriloSantos.PedidosApp.Startup))]

namespace MuriloSantos.PedidosApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888

        }
    }
}
