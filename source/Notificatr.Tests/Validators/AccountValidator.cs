
using Notificatr.Tests.Entities;
using Notificatr.Validations.Validators;

namespace Notificatr.Tests.Validators
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
