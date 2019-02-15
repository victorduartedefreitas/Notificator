using Notificatr.Notifications;
using Notificatr.Validations.Rules;

namespace Notificatr.Validations
{
    public partial class Validation<TEntity>
        where TEntity : class, INotifiable
    {
        public Validation<TEntity> AreEquals(object value, object comparer, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new EqualsRule(value, comparer, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> AreNotEquals(object value, object comparer, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new EqualsRule(value, comparer, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsNotNull(object value, string notificationKey = "IsNotNullRuleViolation", string notificationMessage = "IsNotNullRuleViolation")
        {
            _rules.Add(new NullableRule(value, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsNull(object value, string notificationKey = "IsNullRuleViolation", string notificationMessage = "IsNullRuleViolation")
        {
            _rules.Add(new NullableRule(value, true, notificationKey, notificationMessage));
            return this;
        }
    }
}
