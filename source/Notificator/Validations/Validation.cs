using Notificator.Validations.Rules;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Notificator.Validations
{
    /// <summary>
    /// Class to create the rules of entity validation
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public partial class Validation
    {
        #region Fields

        private List<IRule> _rules;

        /// <summary>
        /// All validation rules
        /// </summary>
        public IReadOnlyCollection<IRule> Rules => _rules;

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor of Validation
        /// </summary>
        /// <param name="entity">Entity to validate</param>
        public Validation()
        {
            _rules = new List<IRule>();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Clear the list of validation rules
        /// </summary>
        public void ClearRules()
        {
            _rules?.Clear();
        }

        #endregion

        #region Private Methods

        private T CompilePropertyValue<T>(Expression<Func<T>> expression)
        {
            PropertyInfo propertyInfo;

            if (expression.Body is UnaryExpression)
            {
                propertyInfo = ((MemberExpression)((UnaryExpression)expression.Body).Operand).Member as PropertyInfo;
            }
            else
            {
                propertyInfo = ((MemberExpression)expression.Body).Member as PropertyInfo;
            }

            if (propertyInfo == null)
            {
                throw new ArgumentException("The lambda expression 'property' should point to a valid Property");
            }

            //string parentClassName = ((MemberInfo)propertyInfo).DeclaringType.Name;
            //string propertyName = propertyInfo.Name;
            //string propertyType = propertyInfo.GetMethod.ReturnType.Name; //string, int, double

            T propertyValue = expression.Compile()();
            return propertyValue;
        }

        #endregion
    }
}
