using Notificatr.Validations.Rules;

namespace Notificatr.Tests.Validators
{
    public class BalanceGreaterThanZeroCustomRule : CustomRule
    {
        public BalanceGreaterThanZeroCustomRule(object[] parameters, string notificationKey, string notificationMessage) : base(parameters, notificationKey, notificationMessage)
        {
        }

        public override bool Validate()
        {
            if (Parameters == null || Parameters.Length == 0)
                return false;

            double balance = 0;
            if (!double.TryParse(Parameters[0].ToString(), out balance))
                return false;

            return balance > 0;
        }
    }
}
