using Notificator.Notifications;
using System;

namespace Notificator.Validations.Validators
{
    public abstract class EntityValidator<TEntity>
        where TEntity : class, INotifiable
    {
        #region Fields

        public event EventHandler OnValidated;
        protected readonly TEntity Entity;
        public Validation<TEntity> Validation { get; private set; }

        #endregion

        #region Constructors

        protected EntityValidator(TEntity entity)
        {
            Entity = entity ?? throw new ArgumentNullException(nameof(entity));
        }

        #endregion

        #region Protected Methods

        protected Validation<TEntity> CreateValidation()
        {
            Validation = new Validation<TEntity>(Entity);
            return Validation;
        }

        #endregion

        #region Public Methods

        public void Validate()
        {
            CreateValidatorInstance();

            foreach (var rule in Validation.Rules)
                if (!rule.Validate())
                    Entity.AddNotification(new Notification(rule.NotificationKey, rule.NotificationMessage));

            OnValidated?.Invoke(this, EventArgs.Empty);
        }

        protected abstract void CreateValidatorInstance();

        #endregion
    }
}
