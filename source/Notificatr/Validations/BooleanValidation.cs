using Notificator.Notifications;
using Notificator.Validations.Rules;

namespace Notificator.Validations
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
