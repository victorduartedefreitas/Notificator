using Notificatr.Notifications;
using Notificatr.Validations.Rules;

namespace Notificatr.Validations
{
    public partial class Validation<TEntity>
        where TEntity : class, INotifiable
    {
        public Validation<TEntity> IsTrue(bool value, string notificationKey = "IsTrueRuleViolation", string notificationMessage = "IsTrueRuleViolation")
        {
            _rules.Add(new BooleanRule(value, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsFalse(bool value, string notificationKey = "IsFalseRuleViolation", string notificationMessage = "IsFalseRuleViolation")
        {
            _rules.Add(new BooleanRule(value, false, notificationKey, notificationMessage));
            return this;
        }
    }
}
