using Notificatr.Notifications;
using Notificatr.Validations.Rules;
using System;
using System.Text.RegularExpressions;

namespace Notificatr.Validations
{
    public partial class Validation<TEntity>
        where TEntity : class, INotifiable
    {
        /// <summary>
        /// Validate if a string is not null or empty
        /// </summary>
        /// <param name="value">string to validate</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation<TEntity> IsNotNullOrEmpty(string value, string notificationKey = "IsNotNullOrEmptyRuleViolation", string notificationMessage = "IsNotNullOrEmptyRuleViolation")
        {
            _rules.Add(new StringNullOrEmptyRule(value, false, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if a string is null or empty
        /// </summary>
        /// <param name="value">string to validate</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation<TEntity> IsNullOrEmpty(string value, string notificationKey = "IsNullOrEmptyRuleViolation", string notificationMessage = "IsNullOrEmptyRuleViolation")
        {
            _rules.Add(new StringNullOrEmptyRule(value, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if a string is not null or white space
        /// </summary>
        /// <param name="value">string to validate</param>
        /// <param name="notificationKey">key of notification</param>
        /// <param name="notificationMessage">message of notification</param>
        /// <returns></returns>
        public Validation<TEntity> IsNotNullOrWhiteSpace(string value, string notificationKey = "IsNotNullOrWhiteSpaceRuleViolation", string notificationMessage = "IsNotNullOrWhiteSpaceRuleViolation")
        {
            _rules.Add(new StringNotNullOrWhiteSpaceRule(value, false, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if a string is null or whitespace
        /// </summary>
        /// <param name="value">String to validate</param>
        /// <param name="notificationKey">Key of notification</param>
        /// <param name="notificationMessage">Message of notification</param>
        /// <returns></returns>
        public Validation<TEntity> IsNullOrWhiteSpace(string value, string notificationKey = "IsNullOrWhiteSpaceRuleViolation", string notificationMessage = "IsNullOrWhiteSpaceRuleViolation")
        {
            _rules.Add(new StringNotNullOrWhiteSpaceRule(value, true, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the MinLenght of a string matches the value
        /// </summary>
        /// <param name="value">String to validate</param>
        /// <param name="minLenght">Min lenght to validate</param>
        /// <param name="notificationKey">Key of notification</param>
        /// <param name="notificationMessage">Message of notification</param>
        /// <returns></returns>
        public Validation<TEntity> HasMinLenght(string value, int minLenght, string notificationKey = "HasMinLenghtRuleViolation", string notificationMessage = "HasMinLenghtRuleViolation")
        {
            _rules.Add(new StringMinLenghtRule(value, minLenght, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the MaxLenght of a string matches the value
        /// </summary>
        /// <param name="value">String to validate</param>
        /// <param name="maxLenght">Max lenght to validate</param>
        /// <param name="notificationKey">Key of notification</param>
        /// <param name="notificationMessage">Message of notification</param>
        /// <returns></returns>
        public Validation<TEntity> HasMaxLenght(string value, int maxLenght, string notificationKey = "HasMaxLenghtRuleViolation", string notificationMessage = "HasMaxLenghtRuleViolation")
        {
            _rules.Add(new StringMaxLenghtRule(value, maxLenght, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if a string has a exactly lenght
        /// </summary>
        /// <param name="value">String to validate</param>
        /// <param name="lenght">Lenght to validate</param>
        /// <param name="notificationKey">Key of notification</param>
        /// <param name="notificationMessage">Message of notification</param>
        /// <returns></returns>
        public Validation<TEntity> HasExactlyLenght(string value, int lenght, string notificationKey = "HasExactlyLenghtRuleViolation", string notificationMessage = "HasExactlyLenghtRuleViolation")
        {
            _rules.Add(new StringExactlyLenghtRule(value, lenght, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if a specified substring occur within the string
        /// </summary>
        /// <param name="value">Main string to validate</param>
        /// <param name="contains">The text that needs occurs within the 'value'</param>
        /// <param name="notificationKey">Key of notification</param>
        /// <param name="notificationMessage">Message of notification</param>
        /// <returns></returns>
        public Validation<TEntity> Contains(string value, string contains, string notificationKey = "ContainsRuleViolation", string notificationMessage = "ContainsRuleViolation")
        {
            _rules.Add(new StringContainsRule(value, contains, notificationKey, notificationMessage));
            return this;
        }

        /// <summary>
        /// Validate if the 2 strings are equals
        /// </summary>
        /// <param name="value">Main text to compare</param>
        /// <param name="comparer">Second text to compare</param>
        /// <param name="notificationKey">Key of notification</param>
        /// <param name="notificationMessage">Message of notification</param>
        /// <param name="comparison">One of the enumeration values that specifies the rules for the comparison</param>
        /// <returns></returns>
        public Validation<TEntity> AreEquals(string value, string comparer, string notificationKey = "AreEqualsRuleViolation", string notificationMessage = "AreEqualsRuleViolation", StringComparison comparison = StringComparison.CurrentCultureIgnoreCase)
        {
            _rules.Add(new StringEqualsRule(value, comparer, true, notificationKey, notificationMessage, comparison));
            return this;
        }

        /// <summary>
        /// Validate if the 2 strings are not equals
        /// </summary>
        /// <param name="value">Main text to compare</param>
        /// <param name="comparer">Second text to compare</param>
        /// <param name="notificationKey">Key of notification</param>
        /// <param name="notificationMessage">Message of notification</param>
        /// <param name="comparison">One of the enumeration values that specifies the rules for the comparison</param>
        /// <returns></returns>
        public Validation<TEntity> AreNotEquals(string value, string comparer, string notificationKey = "AreNotEqualsRuleViolation", string notificationMessage = "AreNotEqualsRuleViolation", StringComparison comparison = StringComparison.CurrentCultureIgnoreCase)
        {
            _rules.Add(new StringEqualsRule(value, comparer, false, notificationKey, notificationMessage, comparison));
            return this;
        }

        /// <summary>
        /// Validate if the input text matches the regular expression
        /// </summary>
        /// <param name="input">Text to validate</param>
        /// <param name="pattern">Pattern that validates the input</param>
        /// <param name="notificationKey">Key of notification</param>
        /// <param name="notificationMessage">Message of notification</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching</param>
        /// <returns></returns>
        public Validation<TEntity> RegexIsMatch(string input, string pattern, string notificationKey = "RegexMatchRuleViolation", string notificationMessage = "RegexMatchRuleViolation", RegexOptions options = RegexOptions.IgnoreCase)
        {
            _rules.Add(new StringRegexRule(input, pattern, notificationKey, notificationMessage, options));
            return this;
        }
    }
}
