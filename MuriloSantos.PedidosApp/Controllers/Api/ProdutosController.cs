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
    public class ProdutosController : ApiController
    {
        private IProdutoAppService _app;

        public ProdutosController(IProdutoAppService app)
        {
            _app = app;
        }

        public IEnumerable<ProdutoViewModel> Get()
        {
            var produtos = _app.ListarProdutos();
            return produtos;
        }
    }
}