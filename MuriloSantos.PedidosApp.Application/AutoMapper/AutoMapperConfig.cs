using AutoMapper;
using MuriloSantos.PedidosApp.Application.ViewModels;
using MuriloSantos.PedidosApp.Domain.Entities;

namespace MuriloSantos.PedidosApp.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
            });
        }
    }
}
