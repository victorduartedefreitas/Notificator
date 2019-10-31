using Notificator.Validations.Rules;
using System;
using System.Linq.Expressions;

namespace Notificator.Validations
{
    public partial class Validation
    {
        /// <summary>
        /// Validate if the value is true
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsTrue(bool value, string notificationKey = "IsTrueRuleViolation", string notificationMessage = "IsTrueRuleViolation")
        {
            _rules.Add(new BooleanRule(value, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is true
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsTrue(Expression<Func<bool>> value, string notificationKey = "IsTrueRuleViolation", string notificationMessage = "IsTrueRuleViolation")
        {
            _rules.Add(new BooleanRule(CompilePropertyValue(value), true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is false
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsFalse(bool value, string notificationKey = "IsFalseRuleViolation", string notificationMessage = "IsFalseRuleViolation")
        {
            _rules.Add(new BooleanRule(value, false, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is false
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsFalse(Expression<Func<bool>> value, string notificationKey = "IsFalseRuleViolation", string notificationMessage = "IsFalseRuleViolation")
        {
            _rules.Add(new BooleanRule(CompilePropertyValue(value), false, notificationKey, notificationMessage));
            return this;
        }
    }
}
