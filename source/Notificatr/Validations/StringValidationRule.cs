using Notificatr.Notifications;
using Notificatr.Validations.Rules;
using System;

namespace Notificatr.Validations
{
    public partial class ValidationRule<TEntity>
        where TEntity : class, INotifiable
    {
        public ValidationRule<TEntity> IsNotNullOrEmpty(string value, string notificationKey = "IsNotNullOrEmptyRuleViolation", string notificationMessage = "IsNotNullOrEmptyRuleViolation")
        {
            _rules.Add(new StringNullOrEmptyRule(value, false, notificationKey, notificationMessage));
            return this;
        }

        public ValidationRule<TEntity> IsNullOrEmpty(string value, string notificationKey = "IsNullOrEmptyRuleViolation", string notificationMessage = "IsNullOrEmptyRuleViolation")
        {
            _rules.Add(new StringNullOrEmptyRule(value, true, notificationKey, notificationMessage));
            return this;
        }

        public ValidationRule<TEntity> IsNotNullOrWhiteSpace(string value, string notificationKey = "IsNotNullOrWhiteSpaceRuleViolation", string notificationMessage = "IsNotNullOrWhiteSpaceRuleViolation")
        {
            _rules.Add(new StringNotNullOrWhiteSpaceRule(value, false, notificationKey, notificationMessage));
            return this;
        }

        public ValidationRule<TEntity> IsNullOrWhiteSpace(string value, string notificationKey = "IsNullOrWhiteSpaceRuleViolation", string notificationMessage = "IsNullOrWhiteSpaceRuleViolation")
        {
            _rules.Add(new StringNotNullOrWhiteSpaceRule(value, true, notificationKey, notificationMessage));
            return this;
        }

        public ValidationRule<TEntity> HasMinLenght(string value, int minLenght, string notificationKey = "HasMinLenghtRuleViolation", string notificationMessage = "HasMinLenghtRuleViolation")
        {
            _rules.Add(new StringMinLenghtRule(value, minLenght, notificationKey, notificationMessage));
            return this;
        }

        public ValidationRule<TEntity> HasMaxLenght(string value, int maxLenght, string notificationKey = "HasMaxLenghtRuleViolation", string notificationMessage = "HasMaxLenghtRuleViolation")
        {
            _rules.Add(new StringMaxLenghtRule(value, maxLenght, notificationKey, notificationMessage));
            return this;
        }

        public ValidationRule<TEntity> HasExactlyLenght(string value, int lenght, string notificationKey = "HasExactlyLenghtRuleViolation", string notificationMessage = "HasExactlyLenghtRuleViolation")
        {
            _rules.Add(new StringExactlyLenghtRule(value, lenght, notificationKey, notificationMessage));
            return this;
        }

        public ValidationRule<TEntity> Contains(string value, string contains, string notificationKey = "ContainsRuleViolation", string notificationMessage = "ContainsRuleViolation")
        {
            _rules.Add(new StringContainsRule(value, contains, notificationKey, notificationMessage));
            return this;
        }

        public ValidationRule<TEntity> AreEquals(string value, string comparer, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation", StringComparison comparison = StringComparison.CurrentCultureIgnoreCase)
        {
            _rules.Add(new StringEqualsRule(value, comparer, true, notificationKey, notificationMessage, comparison));
            return this;
        }

        public ValidationRule<TEntity> AreNotEquals(string value, string comparer, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation", StringComparison comparison = StringComparison.CurrentCultureIgnoreCase)
        {
            _rules.Add(new StringEqualsRule(value, comparer, false, notificationKey, notificationMessage, comparison));
            return this;
        }
    }
}
