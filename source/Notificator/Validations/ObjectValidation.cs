using Notificator.Notifications;
using Notificator.Validations.Rules;

namespace Notificator.Validations
{
    public partial class Validation<TEntity>
        where TEntity : class, INotifiable
    {
        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="comparer">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation<TEntity> AreEquals(object value, object comparer, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new EqualsRule(value, comparer, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is not equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="comparer">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation<TEntity> AreNotEquals(object value, object comparer, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new EqualsRule(value, comparer, false, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is not null
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation<TEntity> IsNotNull(object value, string notificationKey = "IsNotNullRuleViolation", string notificationMessage = "IsNotNullRuleViolation")
        {
            _rules.Add(new NullableRule(value, false, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is null
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation<TEntity> IsNull(object value, string notificationKey = "IsNullRuleViolation", string notificationMessage = "IsNullRuleViolation")
        {
            _rules.Add(new NullableRule(value, true, notificationKey, notificationMessage));
            return this;
        }
    }
}
