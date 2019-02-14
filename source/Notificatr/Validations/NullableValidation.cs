using Notificatr.Notifications;
using Notificatr.Validations.Rules;

namespace Notificatr.Validations
{
    public partial class Validation<TEntity>
        where TEntity : class, INotifiable
    {
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
