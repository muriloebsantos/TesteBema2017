using MuriloSantos.PedidosApp.Domain.Interfaces.Specification;
using MuriloSantos.PedidosApp.Domain.Interfaces.Validation;

namespace MuriloSantos.PedidosApp.Domain.Validation
{
    public class ValidationRule<T> : IValidationRule<T> where T : class
    {
        private readonly ISpecification<T> _specification;

        public ValidationRule(ISpecification<T> specificationRule, string errorMessage)
        {
            _specification = specificationRule;
            ErrorMessage = errorMessage;
        }

        public string ErrorMessage { get; private set; }
        public bool Valid(T entity)
        {
            return _specification.IsSatisfiedBy(entity);
        }
    }
}
