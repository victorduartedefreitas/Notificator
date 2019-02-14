using Notificatr.Notifications;
using Notificatr.Validations.Rules;
using System;
using System.Collections.Generic;

namespace Notificatr.Validations
{
    public partial class Validation<TEntity>
        where TEntity : class, INotifiable
    {
        #region Fields

        private readonly TEntity _entity;
        private List<IRule> _rules;

        public IReadOnlyCollection<IRule> Rules => _rules;

        #endregion

        #region Constructors

        public Validation(TEntity entity)
        {
            _entity = entity ?? throw new ArgumentNullException(nameof(entity));
            _rules = new List<IRule>();
        }

        #endregion
    }
}
