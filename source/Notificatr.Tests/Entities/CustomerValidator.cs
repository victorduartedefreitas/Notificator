using Notificatr.Validations.Validators;

namespace Notificatr.Tests.Entities
{
    public class CustomerValidator : EntityValidator<Customer>
    {
        public CustomerValidator(Customer entity) : base(entity)
        {
            CreateValidation()
                .IsNotNullOrEmpty(entity.Address);
        }
    }
}
