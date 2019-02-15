
using Notificator.Tests.Entities;
using Notificator.Validations.Validators;

namespace Notificator.Tests.Validators
{
    public class AccountValidator : EntityValidator<Account>
    {
        public AccountValidator(Account entity) : base(entity)
        {
        }

        protected override void CreateValidatorInstance()
        {
            CreateValidation()
                .AddCustomRule<BalanceGreaterThanZeroCustomRule>(new object[] { Entity.Balance }, "BalanceGreaterThanZeroCustomRuleViolation", "Balance must be greater than zero.");
        }
    }
}
