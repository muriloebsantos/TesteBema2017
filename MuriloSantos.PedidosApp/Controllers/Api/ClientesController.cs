using MuriloSantos.PedidosApp.Application.Interfaces;
using MuriloSantos.PedidosApp.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MuriloSantos.PedidosApp.Controllers.Api
{
    public class ClientesController : ApiController
    {
        private readonly IClienteAppService _app;

        public ClientesController(IClienteAppService app)
        {
            _app = app;
        }

        public IEnumerable<ClienteViewModel> Get()
        {
            var clientes = _app.ListarClientes();
            return clientes;
        }
    }
}