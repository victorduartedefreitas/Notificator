using System.Collections.Generic;
using System.Linq;

namespace Notificatr.Notifications
{
    public abstract class NotifiableEntity : INotifiable
    {
        #region Fields

        private readonly List<Notification> _notifications;
        public IReadOnlyCollection<Notification> Notifications => _notifications;
        public bool IsValid => !_notifications.Any();

        #endregion

        #region Constructors

        protected NotifiableEntity()
        {
            _notifications = new List<Notification>();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="key"></param>
        /// <param name="message"></param>
        public void AddNotification(string key, string message)
        {
            _notifications.Add(new Notification(key, message));
        }

        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notification"></param>
        public void AddNotification(Notification notification)
        {
            _notifications.Add(notification);
        }

        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notifications"></param>
        public void AddNotifications(IList<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notifications"></param>
        public void AddNotifications(ICollection<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notifications"></param>
        public void AddNotifications(IReadOnlyCollection<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notifiableItem"></param>
        public void AddNotifications(INotifiable notifiableItem)
        {
            _notifications.AddRange(notifiableItem.Notifications);
        }

        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notifiableItems"></param>
        public void AddNotifications(params INotifiable[] notifiableItems)
        {
            foreach (var item in notifiableItems)
                _notifications.AddRange(item.Notifications);
        }

        /// <summary>
        /// Action before the 'DoValidate' method
        /// </summary>
        protected virtual void BeforeValidate() { }

        /// <summary>
        /// Action after the 'DoValidate' method
        /// </summary>
        protected virtual void AfterValidate() { }

        /// <summary>
        /// Method to validate the entity with the 'entityValidator'
        /// </summary>
        protected abstract void DoValidate();

        /// <summary>
        /// Encapsulates the BeforeValidate, DoValidate and AfterValidate methods
        /// </summary>
        public void Validate()
        {
            BeforeValidate();
            DoValidate();
            AfterValidate();
        }

        #endregion
    }
}
