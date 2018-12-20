using MuriloSantos.PedidosApp.Domain.Interfaces.Repositories;

namespace MuriloSantos.PedidosApp.Infra.Data.Seeds
{
    public interface ISeeder<T> where T : class
    {
        void Seed(INoSqlRepository<T> repositorio);
    }
}
