using Notificator.Tests.Entities;
using Notificator.Validations.Validators;

namespace Notificator.Tests.Validators
{
    public class CustomerValidator : EntityValidator<ICustomer>
    {
        public CustomerValidator(ICustomer entity) : base(entity)
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
