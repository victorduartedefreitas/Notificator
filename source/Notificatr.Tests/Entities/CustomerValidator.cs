using Notificatr.Validations;

namespace Notificatr.Tests.Entities
{
    public class CustomerValidator : EntityValidator<Customer>
    {
        public CustomerValidator(Customer entity) : base(entity)
        {
            CreateRule()
                .IsNotNullOrEmpty(entity.Address);
        }
    }
}
