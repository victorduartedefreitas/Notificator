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
        public Validation IsGreaterThan(TimeSpan value, TimeSpan compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new TimeSpanGreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(TimeSpan value, TimeSpan compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new TimeSpanGreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(TimeSpan value, TimeSpan compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new TimeSpanGreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(TimeSpan value, TimeSpan compareTo, string notificationKey = "IsLowerThanOrEquals", string notificationMessage = "IsLowerThanOrEquals")
        {
            _rules.Add(new TimeSpanGreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is between two other values
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="minTimeSpan">minimum value</param>
        /// <param name="maxTimeSpan">maximum value</param>
        /// <param name="inclusive">identifies if the value can be equals to minTimeSpan or maxTimeSpan values</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsBetween(TimeSpan value, TimeSpan minTimeSpan, TimeSpan maxTimeSpan, bool inclusive, string notificationKey = "IsLowerThanOrEquals", string notificationMessage = "IsLowerThanOrEquals")
        {
            _rules.Add(new TimeSpanBetweenRule(value, minTimeSpan, maxTimeSpan, inclusive, notificationKey, notificationMessage));
            return this;
        }
    }
}
