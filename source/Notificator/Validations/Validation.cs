using Notificator.Validations.Rules;
using System.Collections.Generic;

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
    }
}
