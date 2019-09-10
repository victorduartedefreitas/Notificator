using Notificator.Core;
using Notificator.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Notificator
{
    public abstract class NotifiableEntity<INotifiableEntity, IValidator> : INotifiable
        where INotifiableEntity : INotifiable
        where IValidator : IEntityValidator<INotifiableEntity>
    {
        #region Fields

        private readonly List<Notification> _notifications = new List<Notification>();
        private readonly IValidator _validator;

        #endregion

        #region Properties

        /// <summary>
        /// All notifications
        /// </summary>
        public IReadOnlyCollection<Notification> Notifications => _notifications;
        /// <summary>
        /// Identifies if the entity is valid
        /// </summary>
        public bool IsValid => !_notifications.Any();

        #endregion

        #region Constructors

        protected NotifiableEntity()
        {
            var constructorInfo = typeof(IValidator).GetConstructor(new[] { typeof(INotifiableEntity) });
            var args = new object[] { this };
            _validator = (IValidator)constructorInfo.Invoke(args);

            if (_validator != null)
                _validator.OnValidated += OnValidated;
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Executed when the validation has been done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void OnValidated(object sender, EventArgs e) { }

        /// <summary>
        /// Action before the Validate method
        /// </summary>
        protected virtual void BeforeValidate() { }

        /// <summary>
        /// Action after the Validate method
        /// </summary>
        protected virtual void AfterValidate() { }

        #endregion

        #region Public Methods

        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="key">notification key</param>
        /// <param name="message">notification message</param>
        public void AddNotification(string key, string message)
        {
            _notifications.Add(new Notification(key, message));
        }

        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notification">notification</param>
        public void AddNotification(Notification notification)
        {
            _notifications.Add(notification);
        }

        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notifications">collection of notifications</param>
        public void AddNotifications(IList<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notifications">collection of notifications</param>
        public void AddNotifications(ICollection<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notifications">collection of notifications</param>
        public void AddNotifications(IReadOnlyCollection<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notifiableItem">notifiable item</param>
        public void AddNotifications(INotifiable notifiableItem)
        {
            _notifications.AddRange(notifiableItem.Notifications);
        }

        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notifiableItems">array of notifiable items</param>
        public void AddNotifications(params INotifiable[] notifiableItems)
        {
            foreach (var item in notifiableItems)
                _notifications.AddRange(item.Notifications);
        }

        /// <summary>
        /// Encapsulates the BeforeValidate, DoValidate and AfterValidate methods
        /// </summary>
        public void Validate()
        {
            BeforeValidate();
            _validator.Validate();
            AfterValidate();
        }

        #endregion
    }
}
