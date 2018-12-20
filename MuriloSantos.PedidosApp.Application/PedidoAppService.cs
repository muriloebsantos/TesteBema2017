using MuriloSantos.PedidosApp.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuriloSantos.PedidosApp.Application.ViewModels;
using MuriloSantos.PedidosApp.Domain.Entities;
using AutoMapper;
using MuriloSantos.PedidosApp.Domain.Interfaces.Repositories;
using MuriloSantos.PedidosApp.Domain.Entities.Specifications.ProdutoSpecs;
using MuriloSantos.PedidosApp.Domain.Validation;
using MuriloSantos.PedidosApp.Domain.Entities.Validations.ItemPedidoValidations;
using MuriloSantos.PedidosApp.Domain.Entities.Validations.PedidoValidations;

namespace MuriloSantos.PedidosApp.Application
{
    public class PedidoAppService : IPedidoAppService
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        private readonly IPedidoRepositorio _pedidoRepositorio;
        public PedidoAppService(IProdutoRepositorio produtoRepositorio, IPedidoRepositorio pedidoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
            _pedidoRepositorio = pedidoRepositorio;
        }

        public PedidoViewModel AdicionarItem(PedidoViewModel pedidoViewModel, Guid codigoProduto)
        {
            Pedido pedido = Mapper.Map<Pedido>(pedidoViewModel);
            Produto produto = _produtoRepositorio.First(new EncontrarProdutoPorIdSpec(codigoProduto).ToExpression());
            int qtde = 1;

            pedido.AdicionarItem(produto.Id, qtde, produto.Valor);
            pedido.CalcularTotal();

            pedidoViewModel = Mapper.Map<PedidoViewModel>(pedido);
            PreencherDescricaoItensPedido(pedidoViewModel);

            return pedidoViewModel;
        }

        public PedidoViewModel RemoverItem(PedidoViewModel pedidoViewModel, Guid codigoProduto)
        {
            Pedido pedido = Mapper.Map<Pedido>(pedidoViewModel);
            pedido.RemoverItem(codigoProduto);
            pedido.CalcularTotal();

            pedidoViewModel = Mapper.Map<PedidoViewModel>(pedido);
            PreencherDescricaoItensPedido(pedidoViewModel);

            return pedidoViewModel;
        }

        private void PreencherDescricaoItensPedido(PedidoViewModel pedido)
        {
            foreach (ItemPedidoViewModel item in pedido.Itens)
            {
                Produto produto = _produtoRepositorio.First(new EncontrarProdutoPorIdSpec(item.ProdutoId).ToExpression());
                item.DescricaoProduto = produto.Descricao;
            }
        }

        public ValidationResultViewModel GravarPedido(PedidoViewModel pedidoViewModel)
        {
            var validationResult = new ValidationResultViewModel();
            Pedido pedido = Mapper.Map<Pedido>(pedidoViewModel);

            foreach (ItemPedido item in pedido.Itens)
            {
                var validacaoItem = new ItemPedidoValidoParaGravacao();
                ValidationResult resultadoValidacaoItem = validacaoItem.Valid(item);
                if (!resultadoValidacaoItem.IsValid)
                    validationResult.Errors.AddRange(resultadoValidacaoItem.Errors.Select(e => e.Message).Distinct());
            }

            var validacao = new PedidoAptoParaGravacao();
            ValidationResult resultadoValidacaoPedido = validacao.Valid(pedido);
            if (!resultadoValidacaoPedido.IsValid)
                validationResult.Errors.AddRange(resultadoValidacaoPedido.Errors.Select(e => e.Message));

            if (validationResult.IsValid)
                _pedidoRepositorio.Insert(pedido);

            return validationResult;
        }

        public KeyValuePair<long, List<PedidoViewModel>> ConsultarPedidos(ConsultaPedidoViewModel dadosPesquisa)
        {
            throw new NotImplementedException();
        }
    }
}
