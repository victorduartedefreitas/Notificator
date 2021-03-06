﻿using Notificator.Validations.Rules;
using System;
using System.Linq.Expressions;

namespace Notificator.Validations
{
    public partial class Validation
    {
        #region Decimal Rules

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(decimal value, decimal compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new DecimalGreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(Expression<Func<decimal>> value, decimal compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new DecimalGreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(Expression<Func<decimal>> value, Expression<Func<decimal>> compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new DecimalGreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(decimal value, decimal compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new DecimalGreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(Expression<Func<decimal>> value, decimal compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new DecimalGreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, true, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(Expression<Func<decimal>> value, Expression<Func<decimal>> compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new DecimalGreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, true, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(decimal value, decimal compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new DecimalGreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(Expression<Func<decimal>> value, decimal compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new DecimalGreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(Expression<Func<decimal>> value, Expression<Func<decimal>> compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new DecimalGreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(decimal value, decimal compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new DecimalGreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(Expression<Func<decimal>> value, decimal compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new DecimalGreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, true, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(Expression<Func<decimal>> value, Expression<Func<decimal>> compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new DecimalGreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, false, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(decimal value, decimal compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new DecimalEqualsRule(value, compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(Expression<Func<decimal>> value, decimal compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new DecimalEqualsRule(CompilePropertyValue(value), compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(Expression<Func<decimal>> value, Expression<Func<decimal>> compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new DecimalEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(decimal value, decimal compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new DecimalEqualsRule(value, compareTo, false, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(Expression<Func<decimal>> value, decimal compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new DecimalEqualsRule(CompilePropertyValue(value), compareTo, false, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(Expression<Func<decimal>> value, Expression<Func<decimal>> compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new DecimalEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, notificationKey, notificationMessage));
            return this;
        }

        #endregion

        #region Double Rules

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(double value, double compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new DoubleGreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(Expression<Func<double>> value, double compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new DoubleGreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(Expression<Func<double>> value, Expression<Func<double>> compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new DoubleGreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(double value, double compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new DoubleGreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(Expression<Func<double>> value, double compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new DoubleGreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, true, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(Expression<Func<double>> value, Expression<Func<double>> compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new DoubleGreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, true, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(double value, double compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new DoubleGreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(Expression<Func<double>> value, double compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new DoubleGreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(Expression<Func<double>> value, Expression<Func<double>> compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new DoubleGreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(double value, double compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new DoubleGreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(Expression<Func<double>> value, double compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new DoubleGreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, true, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(Expression<Func<double>> value, Expression<Func<double>> compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new DoubleGreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, false, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(double value, double compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new DoubleEqualsRule(value, compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(Expression<Func<double>> value, double compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new DoubleEqualsRule(CompilePropertyValue(value), compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(Expression<Func<double>> value, Expression<Func<double>> compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new DoubleEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(double value, double compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new DoubleEqualsRule(value, compareTo, false, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(Expression<Func<double>> value, double compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new DoubleEqualsRule(CompilePropertyValue(value), compareTo, false, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(Expression<Func<double>> value, Expression<Func<double>> compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new DoubleEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, notificationKey, notificationMessage));
            return this;
        }

        #endregion

        #region Float Rules

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(float value, float compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new FloatGreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(Expression<Func<float>> value, float compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new FloatGreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(Expression<Func<float>> value, Expression<Func<float>> compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new FloatGreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(float value, float compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new FloatGreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(Expression<Func<float>> value, float compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new FloatGreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, true, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(Expression<Func<float>> value, Expression<Func<float>> compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new FloatGreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, true, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(float value, float compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new FloatGreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(Expression<Func<float>> value, float compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new FloatGreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(Expression<Func<float>> value, Expression<Func<float>> compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new FloatGreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(float value, float compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new FloatGreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(Expression<Func<float>> value, float compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new FloatGreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, true, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(Expression<Func<float>> value, Expression<Func<float>> compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new FloatGreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, false, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(float value, float compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new FloatEqualsRule(value, compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(Expression<Func<float>> value, float compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new FloatEqualsRule(CompilePropertyValue(value), compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(Expression<Func<float>> value, Expression<Func<float>> compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new FloatEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(float value, float compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new FloatEqualsRule(value, compareTo, false, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(Expression<Func<float>> value, float compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new FloatEqualsRule(CompilePropertyValue(value), compareTo, false, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(Expression<Func<float>> value, Expression<Func<float>> compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new FloatEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, notificationKey, notificationMessage));
            return this;
        }

        #endregion

        #region ULong Rules

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(ulong value, ulong compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new UInt64GreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(Expression<Func<ulong>> value, ulong compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new UInt64GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(Expression<Func<ulong>> value, Expression<Func<ulong>> compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new UInt64GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(ulong value, ulong compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt64GreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(Expression<Func<ulong>> value, ulong compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt64GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, true, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(Expression<Func<ulong>> value, Expression<Func<ulong>> compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt64GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, true, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(ulong value, ulong compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new UInt64GreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(Expression<Func<ulong>> value, ulong compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new UInt64GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(Expression<Func<ulong>> value, Expression<Func<ulong>> compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new UInt64GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(ulong value, ulong compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt64GreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(Expression<Func<ulong>> value, ulong compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt64GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, true, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(Expression<Func<ulong>> value, Expression<Func<ulong>> compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt64GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, false, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(ulong value, ulong compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new UInt64EqualsRule(value, compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(Expression<Func<ulong>> value, ulong compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new UInt64EqualsRule(CompilePropertyValue(value), compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(Expression<Func<ulong>> value, Expression<Func<ulong>> compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new UInt64EqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(ulong value, ulong compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new UInt64EqualsRule(value, compareTo, false, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(Expression<Func<ulong>> value, ulong compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new UInt64EqualsRule(CompilePropertyValue(value), compareTo, false, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(Expression<Func<ulong>> value, Expression<Func<ulong>> compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new UInt64EqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, notificationKey, notificationMessage));
            return this;
        }

        #endregion

        #region Long Rules

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(long value, long compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new Int64GreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(Expression<Func<long>> value, long compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new Int64GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(Expression<Func<long>> value, Expression<Func<long>> compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new Int64GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(long value, long compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int64GreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(Expression<Func<long>> value, long compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int64GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, true, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(Expression<Func<long>> value, Expression<Func<long>> compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int64GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, true, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(long value, long compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new Int64GreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(Expression<Func<long>> value, long compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new Int64GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(Expression<Func<long>> value, Expression<Func<long>> compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new Int64GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(long value, long compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int64GreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(Expression<Func<long>> value, long compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int64GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, true, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(Expression<Func<long>> value, Expression<Func<long>> compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int64GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, false, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(long value, long compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new Int64EqualsRule(value, compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(Expression<Func<long>> value, long compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new Int64EqualsRule(CompilePropertyValue(value), compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(Expression<Func<long>> value, Expression<Func<long>> compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new Int64EqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(long value, long compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new Int64EqualsRule(value, compareTo, false, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(Expression<Func<long>> value, long compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new Int64EqualsRule(CompilePropertyValue(value), compareTo, false, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(Expression<Func<long>> value, Expression<Func<long>> compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new Int64EqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, notificationKey, notificationMessage));
            return this;
        }

        #endregion

        #region UInt Rules

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(uint value, uint compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new UInt32GreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(Expression<Func<uint>> value, uint compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new UInt32GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(Expression<Func<uint>> value, Expression<Func<uint>> compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new UInt32GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(uint value, uint compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt32GreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(Expression<Func<uint>> value, uint compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt32GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, true, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(Expression<Func<uint>> value, Expression<Func<uint>> compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt32GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, true, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(uint value, uint compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new UInt32GreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(Expression<Func<uint>> value, uint compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new UInt32GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(Expression<Func<uint>> value, Expression<Func<uint>> compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new UInt32GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(uint value, uint compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt32GreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(Expression<Func<uint>> value, uint compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt32GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, true, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(Expression<Func<uint>> value, Expression<Func<uint>> compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt32GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, false, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(uint value, uint compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new UInt32EqualsRule(value, compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(Expression<Func<uint>> value, uint compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new UInt32EqualsRule(CompilePropertyValue(value), compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(Expression<Func<uint>> value, Expression<Func<uint>> compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new UInt32EqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(uint value, uint compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new UInt32EqualsRule(value, compareTo, false, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(Expression<Func<uint>> value, uint compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new UInt32EqualsRule(CompilePropertyValue(value), compareTo, false, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(Expression<Func<uint>> value, Expression<Func<uint>> compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new UInt32EqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, notificationKey, notificationMessage));
            return this;
        }

        #endregion

        #region Int Rules

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(int value, int compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new Int32GreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(Expression<Func<int>> value, int compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new Int32GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(Expression<Func<int>> value, Expression<Func<int>> compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new Int32GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(int value, int compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int32GreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(Expression<Func<int>> value, int compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int32GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, true, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(Expression<Func<int>> value, Expression<Func<int>> compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int32GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, true, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(int value, int compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new Int32GreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(Expression<Func<int>> value, int compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new Int32GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(Expression<Func<int>> value, Expression<Func<int>> compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new Int32GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(int value, int compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int32GreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(Expression<Func<int>> value, int compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int32GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, true, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(Expression<Func<int>> value, Expression<Func<int>> compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int32GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, false, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(int value, int compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new Int32EqualsRule(value, compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(Expression<Func<int>> value, int compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new Int32EqualsRule(CompilePropertyValue(value), compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(Expression<Func<int>> value, Expression<Func<int>> compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new Int32EqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(int value, int compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new Int32EqualsRule(value, compareTo, false, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(Expression<Func<int>> value, int compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new Int32EqualsRule(CompilePropertyValue(value), compareTo, false, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(Expression<Func<int>> value, Expression<Func<int>> compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new Int32EqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, notificationKey, notificationMessage));
            return this;
        }

        #endregion

        #region UShort Rules

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(ushort value, ushort compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new UInt16GreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(Expression<Func<ushort>> value, ushort compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new UInt16GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(Expression<Func<ushort>> value, Expression<Func<ushort>> compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new UInt16GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(ushort value, ushort compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt16GreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(Expression<Func<ushort>> value, ushort compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt16GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, true, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(Expression<Func<ushort>> value, Expression<Func<ushort>> compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt16GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, true, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(ushort value, ushort compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new UInt16GreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(Expression<Func<ushort>> value, ushort compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new UInt16GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(Expression<Func<ushort>> value, Expression<Func<ushort>> compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new UInt16GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(ushort value, ushort compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt16GreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(Expression<Func<ushort>> value, ushort compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt16GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, true, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(Expression<Func<ushort>> value, Expression<Func<ushort>> compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new UInt16GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, false, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(ushort value, ushort compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new UInt16EqualsRule(value, compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(Expression<Func<ushort>> value, ushort compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new UInt16EqualsRule(CompilePropertyValue(value), compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(Expression<Func<ushort>> value, Expression<Func<ushort>> compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new UInt16EqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(ushort value, ushort compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new UInt16EqualsRule(value, compareTo, false, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(Expression<Func<ushort>> value, ushort compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new UInt16EqualsRule(CompilePropertyValue(value), compareTo, false, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(Expression<Func<ushort>> value, Expression<Func<ushort>> compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new UInt16EqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, notificationKey, notificationMessage));
            return this;
        }

        #endregion

        #region Short Rules

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(short value, short compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new Int16GreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(Expression<Func<short>> value, short compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new Int16GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(Expression<Func<short>> value, Expression<Func<short>> compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new Int16GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(short value, short compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int16GreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(Expression<Func<short>> value, short compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int16GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, true, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(Expression<Func<short>> value, Expression<Func<short>> compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int16GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, true, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(short value, short compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new Int16GreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(Expression<Func<short>> value, short compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new Int16GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(Expression<Func<short>> value, Expression<Func<short>> compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new Int16GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(short value, short compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int16GreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(Expression<Func<short>> value, short compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int16GreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, true, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(Expression<Func<short>> value, Expression<Func<short>> compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new Int16GreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, false, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(short value, short compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new Int16EqualsRule(value, compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(Expression<Func<short>> value, short compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new Int16EqualsRule(CompilePropertyValue(value), compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(Expression<Func<short>> value, Expression<Func<short>> compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new Int16EqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(short value, short compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new Int16EqualsRule(value, compareTo, false, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(Expression<Func<short>> value, short compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new Int16EqualsRule(CompilePropertyValue(value), compareTo, false, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(Expression<Func<short>> value, Expression<Func<short>> compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new Int16EqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, notificationKey, notificationMessage));
            return this;
        }

        #endregion

        #region Byte Rules

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(byte value, byte compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new ByteGreaterThanOrEqualsRule(value, compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(Expression<Func<byte>> value, byte compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new ByteGreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, false, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is greater than other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation IsGreaterThan(Expression<Func<byte>> value, Expression<Func<byte>> compareTo, string notificationKey = "IsGreaterThanRuleViolation", string notificationMessage = "IsGreaterThanRuleViolation")
        {
            _rules.Add(new ByteGreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(byte value, byte compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new ByteGreaterThanOrEqualsRule(value, compareTo, true, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(Expression<Func<byte>> value, byte compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new ByteGreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, true, true, notificationKey, notificationMessage));
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
        public Validation IsGreaterThanOrEquals(Expression<Func<byte>> value, Expression<Func<byte>> compareTo, string notificationKey = "IsGreaterThanOrEqualsRuleViolation", string notificationMessage = "IsGreaterThanOrEqualsRuleViolation")
        {
            _rules.Add(new ByteGreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, true, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(byte value, byte compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new ByteGreaterThanOrEqualsRule(value, compareTo, false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(Expression<Func<byte>> value, byte compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new ByteGreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThan(Expression<Func<byte>> value, Expression<Func<byte>> compareTo, string notificationKey = "IsLowerThanRuleViolation", string notificationMessage = "IsLowerThanRuleViolation")
        {
            _rules.Add(new ByteGreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(byte value, byte compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new ByteGreaterThanOrEqualsRule(value, compareTo, true, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(Expression<Func<byte>> value, byte compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new ByteGreaterThanOrEqualsRule(CompilePropertyValue(value), compareTo, true, false, notificationKey, notificationMessage));
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
        public Validation IsLowerThanOrEquals(Expression<Func<byte>> value, Expression<Func<byte>> compareTo, string notificationKey = "IsLowerThanOrEqualsRuleViolation", string notificationMessage = "IsLowerThanOrEqualsRuleViolation")
        {
            _rules.Add(new ByteGreaterThanOrEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, false, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(byte value, byte compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new ByteEqualsRule(value, compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(Expression<Func<byte>> value, byte compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new ByteEqualsRule(CompilePropertyValue(value), compareTo, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the value is equals to other value
        /// </summary>
        /// <param name="value">value to validate</param>
        /// <param name="compareTo">value to compare</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation AreEquals(Expression<Func<byte>> value, Expression<Func<byte>> compareTo, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation")
        {
            _rules.Add(new ByteEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), true, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(byte value, byte compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new ByteEqualsRule(value, compareTo, false, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(Expression<Func<byte>> value, byte compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new ByteEqualsRule(CompilePropertyValue(value), compareTo, false, notificationKey, notificationMessage));
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
        public Validation AreNotEquals(Expression<Func<byte>> value, Expression<Func<byte>> compareTo, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation")
        {
            _rules.Add(new ByteEqualsRule(CompilePropertyValue(value), CompilePropertyValue(compareTo), false, notificationKey, notificationMessage));
            return this;
        }

        #endregion
    }
}
