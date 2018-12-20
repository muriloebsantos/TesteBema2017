using MuriloSantos.PedidosApp.Application.Interfaces;
using MuriloSantos.PedidosApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuriloSantos.PedidosApp.Controllers
{
    public class PedidosController : Controller
    {
        public PedidosController()
        {

        }

        // GET: Pedidos
        public ActionResult CriarPedido()
        {
            return View();
        }
    }
}