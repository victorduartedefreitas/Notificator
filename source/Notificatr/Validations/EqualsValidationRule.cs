using Notificatr.Notifications;
using Notificatr.Validations.Rules;

namespace Notificatr.Validations
{
    public partial class ValidationRule<TEntity>
        where TEntity : class, INotifiable
    {
        public ValidationRule<TEntity> AreEquals(object value, object comparer, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new EqualsRule(value, comparer, true, notificationKey, notificationMessage));
            return this;
        }

        public ValidationRule<TEntity> AreNotEquals(object value, object comparer, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new EqualsRule(value, comparer, false, notificationKey, notificationMessage));
            return this;
        }
    }
}
