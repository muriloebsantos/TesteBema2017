using MuriloSantos.PedidosApp.Domain.Entities;
using MuriloSantos.PedidosApp.Domain.Interfaces.Repositories;
using MuriloSantos.PedidosApp.Infra.Data.Seeds;

namespace MuriloSantos.PedidosApp.Infra.Data.Repositories
{
    public class ProdutoRepositorio : NoSqlRepository<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio() : base("produtos")
        {
        }

        static ProdutoRepositorio()
        {
            var repositorio = new ProdutoRepositorio();

            if (repositorio.Count() > 0)
                return;

            new ProdutoSeeder().Seed(repositorio);
        }
    }
}
