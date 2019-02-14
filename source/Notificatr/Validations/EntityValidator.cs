using Notificatr.Notifications;
using System;

namespace Notificatr.Validations
{
    public abstract class EntityValidator<TEntity>
        where TEntity : class, INotifiable
    {
        #region Fields

        private readonly TEntity Entity;
        public ValidationRule<TEntity> Rule { get; private set; }

        #endregion

        #region Constructors

        protected EntityValidator(TEntity entity)
        {
            Entity = entity ?? throw new ArgumentNullException(nameof(entity));
        }

        #endregion

        #region Protected Methods

        protected ValidationRule<TEntity> CreateRule()
        {
            Rule = new ValidationRule<TEntity>(Entity);
            return Rule;
        }

        #endregion

        #region Public Methods

        public void Validate()
        {
            foreach (var rule in Rule.Rules)
                if (!rule.Validate())
                    Entity.AddNotification(new Notification(rule.NotificationKey, rule.NotificationMessage));
        }

        #endregion
    }
}
