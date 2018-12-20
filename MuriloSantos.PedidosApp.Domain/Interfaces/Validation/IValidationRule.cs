namespace MuriloSantos.PedidosApp.Domain.Interfaces.Validation
{
    public interface IValidationRule<T> where T : class
    {
        string ErrorMessage { get; }
        bool Valid(T entidade);
    }
}
