﻿using Notificator.Validations.Rules;
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
        public Validation AreEquals(Guid value, Guid comparer, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
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
        public Validation AreEquals(Expression<Func<Guid>> value, Guid comparer, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
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
        public Validation AreEquals(Expression<Func<Guid>> value, Expression<Func<Guid>> comparer, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
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
        public Validation AreNotEquals(Guid value, Guid comparer, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
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
        public Validation AreNotEquals(Expression<Func<Guid>> value, Guid comparer, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
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
        public Validation AreNotEquals(Expression<Func<Guid>> value, Expression<Func<Guid>> comparer, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new EqualsRule(CompilePropertyValue(value), CompilePropertyValue(comparer), false, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is empty
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsEmpty(Guid value, string notificationKey = "IsEmptyRuleViolation", string notificationMessage = "IsEmptyRuleViolation")
        {
            _rules.Add(new GuidEmptyRule(value, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is empty
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsEmpty(Expression<Func<Guid>> value, string notificationKey = "IsEmptyRuleViolation", string notificationMessage = "IsEmptyRuleViolation")
        {
            _rules.Add(new GuidEmptyRule(CompilePropertyValue(value), true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is not empty
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsNotEmpty(Guid value, string notificationKey = "IsNotEmptyRuleViolation", string notificationMessage = "IsNotEmptyRuleViolation")
        {
            _rules.Add(new GuidEmptyRule(value, false, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is not empty
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsNotEmpty(Expression<Func<Guid>> value, string notificationKey = "IsNotEmptyRuleViolation", string notificationMessage = "IsNotEmptyRuleViolation")
        {
            _rules.Add(new GuidEmptyRule(CompilePropertyValue(value), false, notificationKey, notificationMessage));
            return this;
        }
    }
}
