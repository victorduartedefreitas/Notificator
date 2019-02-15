﻿using Notificator.Notifications;
using Notificator.Validations.Rules;
using System;
using System.Collections.Generic;

namespace Notificator.Validations
{
    //
    //TODO: Mudar a assinatura de todos os métodos do Validation para passar a propriedade num lambdaExpression, ao invés do valor já preenchido.
    //

    /// <summary>
    /// Class to create the rules of entity validation
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public partial class Validation<TEntity>
        where TEntity : class, INotifiable
    {
        #region Fields

        private readonly TEntity _entity;
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
        public Validation(TEntity entity)
        {
            _entity = entity ?? throw new ArgumentNullException(nameof(entity));
            _rules = new List<IRule>();
        }

        #endregion
    }
}
