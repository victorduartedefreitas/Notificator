using Notificator.Notifications;
using System;

namespace Notificator.Validations.Validators
{
    public abstract class EntityValidator<TEntity>
        where TEntity : INotifiable
    {
        #region Fields

        /// <summary>
        /// Fires after validation
        /// </summary>
        public event EventHandler OnValidated;

        /// <summary>
        /// Entity to validate
        /// </summary>
        protected readonly TEntity Entity;

        /// <summary>
        /// Instance of validation with all rules
        /// </summary>
        public Validation Validation { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Creates an instance of EntityValidator
        /// </summary>
        /// <param name="entity"></param>
        protected EntityValidator(TEntity entity)
        {
            Entity = entity;
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Creates an instance of validation
        /// </summary>
        /// <returns></returns>
        protected Validation CreateValidation()
        {
            if (Validation == null)
                Validation = new Validation();

            return Validation;
        }

        /// <summary>
        /// Clear the list of validation rules
        /// </summary>
        protected void ClearValidationRules()
        {
            Validation?.ClearRules();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Execute the validation
        /// </summary>
        public void Validate()
        {
            CreateValidatorInstance();

            foreach (var rule in Validation.Rules)
                if (!rule.Validate())
                    Entity.AddNotification(new Notification(rule.NotificationKey, rule.NotificationMessage));

            OnValidated?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// You should implement this method for create an instance of EntityValidator.
        /// This method is fired at the beginning of Validate method.
        /// </summary>
        protected abstract void CreateValidatorInstance();

        #endregion
    }
}
