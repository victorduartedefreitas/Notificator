
using Notificatr.Tests.Entities;
using Notificatr.Validations.Validators;

namespace Notificatr.Tests.Validators
{
    public class AccountValidator : EntityValidator<Account>
    {
        public AccountValidator(Account entity) : base(entity)
        {
            CreateValidation()
                .IsGreaterThan(entity.Balance, 0, "SaldoNegativo", "O saldo da conta não pode ser negativo");
        }
    }
}
