using MuriloSantos.PedidosApp.Domain.Validation;
using MuriloSantos.PedidosApp.Domain.Entities.Specifications.PedidoSpecs;
using MuriloSantos.PedidosApp.Domain.Messages;

namespace MuriloSantos.PedidosApp.Domain.Entities.Validations.PedidoValidations
{
    public class PedidoAptoParaGravacao : Validation<Pedido>
    {
        public PedidoAptoParaGravacao()
        {
            AddRule(new ValidationRule<Pedido>(new DataEntregaDeveSerMaiorQueDataAtualSpec(), ValidationMessages.Pedido_Data_Deve_Ser_Maior_Que_Atual));
            AddRule(new ValidationRule<Pedido>(new PedidoPossuiItensSpec(), ValidationMessages.Pedido_Deve_Possuir_Itens));
            AddRule(new ValidationRule<Pedido>(new ProdutosNaoSeRepetemSpec(), ValidationMessages.Pedido_Itens_Nao_Devem_Repetir));
        }
    }
}
