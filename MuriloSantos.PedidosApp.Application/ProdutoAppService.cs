using MuriloSantos.PedidosApp.Application.Interfaces;
using System;
using System.Collections.Generic;
using MuriloSantos.PedidosApp.Application.ViewModels;
using MuriloSantos.PedidosApp.Domain.Interfaces.Repositories;
using MuriloSantos.PedidosApp.Domain.Entities;
using AutoMapper;

namespace MuriloSantos.PedidosApp.Application
{
    public class ProdutoAppService : IProdutoAppService
    {
        private readonly IProdutoRepositorio _repositorio;

        public ProdutoAppService(IProdutoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public IEnumerable<ProdutoViewModel> ListarProdutos()
        {
            IEnumerable<Produto> produtos = _repositorio.All();
            var produtosViewModel = Mapper.Map<IEnumerable<ProdutoViewModel>>(produtos);
            return produtosViewModel;
        }
    }
}
