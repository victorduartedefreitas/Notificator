using Notificator.Notifications;
using Notificator.Validations.Rules;
using System;

namespace Notificator.Validations
{
    public partial class Validation<TEntity>
        where TEntity : class, INotifiable
    {
        public Validation<TEntity> IsGreaterThan(DateTime value, DateTime compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new DateTimeGreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsGreaterThanOrEquals(DateTime value, DateTime compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new DateTimeGreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThan(DateTime value, DateTime compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new DateTimeGreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsLowerThanOrEquals(DateTime value, DateTime compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new DateTimeGreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsBetween(DateTime value, DateTime minDate, DateTime maxDate, bool inclusive, string notificationKey = "IsBetweenRuleViolation", string notificationMessage = "IsBetweenRuleViolation")
        {
            _rules.Add(new DateTimeBetweenRule(value, minDate, maxDate, inclusive, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsNotNull(DateTime value, string notificationKey = "IsNotNullRuleViolation", string notificationMessage = "IsNotNullRuleViolation")
        {
            _rules.Add(new DateTimeNullableRule(value, false, notificationKey, notificationMessage));
            return this;
        }

        public Validation<TEntity> IsNull(DateTime value, string notificationKey = "IsNullRuleViolation", string notificationMessage = "IsNullRuleViolation")
        {
            _rules.Add(new DateTimeNullableRule(value, true, notificationKey, notificationMessage));
            return this;
        }
    }
}
