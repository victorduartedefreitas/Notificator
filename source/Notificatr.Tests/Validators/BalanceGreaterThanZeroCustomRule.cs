using Notificatr.Validations.Rules;

namespace Notificatr.Tests.Validators
{
    public class BalanceGreaterThanZeroCustomRule : CustomRule
    {
        public BalanceGreaterThanZeroCustomRule(object[] parameters, string notificationKey, string notificationMessage) : base(parameters, notificationKey, notificationMessage)
        {
            _parameters = parameters;
        }

        private object[] _parameters;

        public override bool Validate()
        {
            if (_parameters == null || _parameters.Length == 0)
                return false;

            double balance = 0;
            if (!double.TryParse(_parameters[0].ToString(), out balance))
                return false;

            return balance > 0;
        }
    }
}
