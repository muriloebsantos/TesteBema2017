using MuriloSantos.PedidosApp.Application.Interfaces;
using MuriloSantos.PedidosApp.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MuriloSantos.PedidosApp.Controllers.Api
{
    public class PedidosController : ApiController
    {
        private readonly IPedidoAppService _app;

        public PedidosController(IPedidoAppService app)
        {
            _app = app;
        }

        [HttpPut]
        public PedidoViewModel AddItem([FromBody]PedidoViewModel pedido, Guid id)
        {
            pedido = _app.AdicionarItem(pedido, id);
            return pedido;
        }

        [HttpDelete]
        public PedidoViewModel RemoveItem([FromBody]PedidoViewModel pedido, Guid id)
        {
            pedido = _app.RemoverItem(pedido, id);
            return pedido;
        }

        [HttpPost]
        public ValidationResultViewModel Gravar([FromBody]PedidoViewModel pedido)
        {
            var result = _app.GravarPedido(pedido);
            return result;
        }
    }
}
