using Notificatr.Notifications;
using Notificatr.Validations.Rules;
using System;

namespace Notificatr.Validations
{
    public partial class Validation<TEntity>
       where TEntity : class, INotifiable
    {
        public Validation<TEntity> IsGreaterThan(TimeSpan value, TimeSpan compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new TimeSpanGreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsGreaterThanOrEquals(TimeSpan value, TimeSpan compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new TimeSpanGreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThan(TimeSpan value, TimeSpan compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new TimeSpanGreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThanOrEquals(TimeSpan value, TimeSpan compareTo, string notificationKey = "IsLowerThanOrEquals", string notificationMessage = "IsLowerThanOrEquals")
        {
            _rules.Add(new TimeSpanGreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsBetween(TimeSpan value, TimeSpan minTimeSpan, TimeSpan maxTimeSpan, bool inclusive, string notificationKey = "IsLowerThanOrEquals", string notificationMessage = "IsLowerThanOrEquals")
        {
            _rules.Add(new TimeSpanBetweenRule(value, minTimeSpan, maxTimeSpan, inclusive, notificationKey, notificationMessage));
            return this;
        }
    }
}
