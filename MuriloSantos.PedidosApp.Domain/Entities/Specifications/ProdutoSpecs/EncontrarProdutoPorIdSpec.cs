using System;
using System.Linq.Expressions;

namespace MuriloSantos.PedidosApp.Domain.Entities.Specifications.ProdutoSpecs
{
    public class EncontrarProdutoPorIdSpec : Specification<Produto>
    {
        private readonly Guid _guid;
        public EncontrarProdutoPorIdSpec(Guid guid)
        {
            _guid = guid;
        }

        public override Expression<Func<Produto, bool>> ToExpression()
        {
            return produto => produto.Id == _guid;
        }
    }
}
