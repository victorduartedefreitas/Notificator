using Notificatr.Validations.Validators;

namespace Notificatr.Tests.Entities
{
    public class CustomerValidator : EntityValidator<Customer>
    {
        public CustomerValidator(Customer entity) : base(entity)
        {
        }

        protected override void CreateValidatorInstance()
        {
            CreateValidation()
                .IsNotNullOrEmpty(Entity.Address)
                .IsNotNullOrWhiteSpace(Entity.FullName)
                .HasMinLenght(Entity.FullName, 10)
                .HasMaxLenght(Entity.FullName, 100);
        }
    }
}
