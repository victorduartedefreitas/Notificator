using Notificator.Core;
using Notificator.Models;
using Notificator.Validations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Notificator
{
    public abstract class NotifiableEntity : INotifiable
    {
        #region Events

        public event EventHandler OnValidated;

        #endregion

        #region Fields

        private readonly List<Notification> _validationMessages = new List<Notification>();

        #endregion

        #region Properties

        /// <summary>
        /// All notifications
        /// </summary>
        public IReadOnlyCollection<Notification> ValidationMessages => _validationMessages;
        /// <summary>
        /// Identifies if the entity is valid
        /// </summary>
        public bool IsValid => !_validationMessages.Any();

        /// <summary>
        /// Instance of validation with all rules
        /// </summary>
        public Validation ValidationInstance { get; } = new Validation();

        #endregion

        #region Protected Methods

        /// <summary>
        /// Action before the Validate method
        /// </summary>
        protected virtual void BeforeValidate() { }

        /// <summary>
        /// Action after the Validate method
        /// </summary>
        protected virtual void AfterValidate() { }

        /// <summary>
        /// Clear the list of validation rules
        /// </summary>
        protected void ClearValidationRules()
        {
            ValidationInstance?.ClearRules();
        }

        protected abstract void CreateValidationRules();

        #endregion

        #region Public Methods

        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="key">notification key</param>
        /// <param name="message">notification message</param>
        public void AddNotification(string key, string message)
        {
            _validationMessages.Add(new Notification(key, message));
        }

        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notification">notification</param>
        public void AddNotification(Notification notification)
        {
            _validationMessages.Add(notification);
        }

        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notifications">collection of notifications</param>
        public void AddNotifications(IList<Notification> notifications)
        {
            _validationMessages.AddRange(notifications);
        }

        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notifications">collection of notifications</param>
        public void AddNotifications(ICollection<Notification> notifications)
        {
            _validationMessages.AddRange(notifications);
        }

        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notifications">collection of notifications</param>
        public void AddNotifications(IReadOnlyCollection<Notification> notifications)
        {
            _validationMessages.AddRange(notifications);
        }

        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notifiableItem">notifiable item</param>
        public void AddNotifications(INotifiable notifiableItem)
        {
            _validationMessages.AddRange(notifiableItem.ValidationMessages);
        }

        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notifiableItems">array of notifiable items</param>
        public void AddNotifications(params INotifiable[] notifiableItems)
        {
            foreach (var item in notifiableItems)
                _validationMessages.AddRange(item.ValidationMessages);
        }

        /// <summary>
        /// Encapsulates the BeforeValidate, DoValidate and AfterValidate methods
        /// </summary>
        public void Validate()
        {
            BeforeValidate();
            InternalValidate();
            AfterValidate();
        }

        #endregion

        #region Private Methods

        private void InternalValidate()
        {
            if (ValidationInstance == null)
                return;

            _validationMessages.Clear();
            ClearValidationRules();
            CreateValidationRules();

            foreach (var rule in ValidationInstance.Rules)
                if (!rule.Validate())
                    AddNotification(new Notification(rule.NotificationKey, rule.NotificationMessage));

            OnValidated?.Invoke(this, EventArgs.Empty);
        }

        #endregion
    }
}
