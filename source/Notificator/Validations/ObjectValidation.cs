using Notificator.Validations.Rules;
using System;
using System.Linq.Expressions;

namespace Notificator.Validations
{
    public partial class Validation
    {
        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="comparer">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(object value, object comparer, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new EqualsRule(value, comparer, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="comparer">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(Expression<Func<object>> value, object comparer, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new EqualsRule(CompilePropertyValue(value), comparer, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="comparer">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(Expression<Func<object>> value, Expression<Func<object>> comparer, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new EqualsRule(CompilePropertyValue(value), CompilePropertyValue(comparer), true, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(object value, object comparer, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new EqualsRule(value, comparer, false, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(Expression<Func<object>> value, object comparer, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new EqualsRule(CompilePropertyValue(value), comparer, false, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(Expression<Func<object>> value, Expression<Func<object>> comparer, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new EqualsRule(CompilePropertyValue(value), CompilePropertyValue(comparer), false, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is not null
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsNotNull(object value, string notificationKey = "IsNotNullRuleViolation", string notificationMessage = "IsNotNullRuleViolation")
        {
            _rules.Add(new NullableRule(value, false, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is not null
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsNotNull(Expression<Func<object>> value, string notificationKey = "IsNotNullRuleViolation", string notificationMessage = "IsNotNullRuleViolation")
        {
            _rules.Add(new NullableRule(CompilePropertyValue(value), false, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is null
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsNull(object value, string notificationKey = "IsNullRuleViolation", string notificationMessage = "IsNullRuleViolation")
        {
            _rules.Add(new NullableRule(value, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is null
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsNull(Expression<Func<object>> value, string notificationKey = "IsNullRuleViolation", string notificationMessage = "IsNullRuleViolation")
        {
            _rules.Add(new NullableRule(CompilePropertyValue(value), true, notificationKey, notificationMessage));
            return this;
        }
    }
}
