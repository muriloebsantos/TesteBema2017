using MuriloSantos.PedidosApp.Domain.Entities.Specifications.ItemPedidoSpecs;
using MuriloSantos.PedidosApp.Domain.Messages;
using MuriloSantos.PedidosApp.Domain.Validation;

namespace MuriloSantos.PedidosApp.Domain.Entities.Validations.ItemPedidoValidations
{
    public class ItemPedidoValidoParaGravacao : Validation<ItemPedido>
    {
        public ItemPedidoValidoParaGravacao()
        {
            AddRule(new ValidationRule<ItemPedido>(new ItemPedidoPossuiQtdeValidaSpec(), ValidationMessages.ItemPedido_Qtde_Invalida));
            AddRule(new ValidationRule<ItemPedido>(new ItemPedidoPossuiValorValidoSpec(), ValidationMessages.ItemPedido_Valor_Invalido));
        }
    }
}
