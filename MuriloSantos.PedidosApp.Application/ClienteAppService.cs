using MuriloSantos.PedidosApp.Application.Interfaces;
using System.Collections.Generic;
using MuriloSantos.PedidosApp.Application.ViewModels;
using MuriloSantos.PedidosApp.Domain.Interfaces.Repositories;
using AutoMapper;
using MuriloSantos.PedidosApp.Domain.Entities;

namespace MuriloSantos.PedidosApp.Application
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly IClienteRepositorio _repositorio;

        public ClienteAppService(IClienteRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public IEnumerable<ClienteViewModel> ListarClientes()
        {
            IEnumerable<Cliente> clientes = _repositorio.All();
            var clientesViewModel = Mapper.Map<IEnumerable<ClienteViewModel>>(clientes);
            return clientesViewModel;
        }
    }
}
