using Notificator.Validations.Rules;
using System;

namespace Notificator.Validations
{
    public partial class Validation
    {
        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(DateTime value, DateTime compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new DateTimeGreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is greater than or equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThanOrEquals(DateTime value, DateTime compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new DateTimeGreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is lower than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsLowerThan(DateTime value, DateTime compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new DateTimeGreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is lower or equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsLowerThanOrEquals(DateTime value, DateTime compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new DateTimeGreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is between two other values
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="minDate">minimum value</param>
        /// <param name="maxDate">maximum value</param>
        /// <param name="inclusive">identifies if the value can be equals to minDate or maxDate values</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsBetween(DateTime value, DateTime minDate, DateTime maxDate, bool inclusive, string notificationKey = "IsBetweenRuleViolation", string notificationMessage = "IsBetweenRuleViolation")
        {
            _rules.Add(new DateTimeBetweenRule(value, minDate, maxDate, inclusive, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is not null
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsNotNull(DateTime? value, string notificationKey = "IsNotNullRuleViolation", string notificationMessage = "IsNotNullRuleViolation")
        {
            _rules.Add(new DateTimeNullableRule(value, false, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is null
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsNull(DateTime? value, string notificationKey = "IsNullRuleViolation", string notificationMessage = "IsNullRuleViolation")
        {
            _rules.Add(new DateTimeNullableRule(value, true, notificationKey, notificationMessage));
            return this;
        }
    }
}
