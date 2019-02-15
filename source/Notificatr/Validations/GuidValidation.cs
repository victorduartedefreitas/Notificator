using Notificatr.Notifications;
using Notificatr.Validations.Rules;
using System;

namespace Notificatr.Validations
{
    public partial class Validation<TEntity>
        where TEntity : class, INotifiable
    {
        public Validation<TEntity> AreEquals(Guid value, Guid comparer, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new EqualsRule(value, comparer, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> AreNotEquals(Guid value, Guid comparer, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new EqualsRule(value, comparer, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsEmpty(Guid value, string notificationKey = "IsEmptyRuleViolation", string notificationMessage = "IsEmptyRuleViolation")
        {
            _rules.Add(new GuidEmptyRule(value, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsNotEmpty(Guid value, string notificationKey = "IsNotEmptyRuleViolation", string notificationMessage = "IsNotEmptyRuleViolation")
        {
            _rules.Add(new GuidEmptyRule(value, false, notificationKey, notificationMessage));
            return this;
        }
    }
}
