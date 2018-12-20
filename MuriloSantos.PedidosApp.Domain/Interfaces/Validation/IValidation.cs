using MuriloSantos.PedidosApp.Domain.Validation;

namespace MuriloSantos.PedidosApp.Domain.Interfaces.Validation
{
    public interface IValidation<T> where T : class
    {
        ValidationResult Valid(T entity);
    }
}
