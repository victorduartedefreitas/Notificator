using Notificator.Tests.Entities;
using Notificator.Validations.Validators;

namespace Notificator.Tests.Validators
{
    public class TransactionValidator : EntityValidator<ITransaction>
    {
        public TransactionValidator(ITransaction entity) : base(entity)
        {
        }

        protected override void CreateValidatorInstance()
        {
        }
    }
}
