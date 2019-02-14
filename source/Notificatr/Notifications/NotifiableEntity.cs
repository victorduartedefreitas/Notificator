using System.Collections.Generic;
using System.Linq;

namespace Notificatr.Notifications
{
    public abstract class NotifiableEntity : INotifiable
    {
        #region Fields

        private readonly List<Notification> _notifications;
        public IReadOnlyCollection<Notification> Notifications => _notifications;
        public bool IsValid => _notifications.Any();

        #endregion

        #region Constructors

        protected NotifiableEntity()
        {
            _notifications = new List<Notification>();
        }

        #endregion

        #region Public Methods

        public void AddNotification(string key, string message)
        {
            _notifications.Add(new Notification(key, message));
        }

        public void AddNotification(Notification notification)
        {
            _notifications.Add(notification);
        }

        public void AddNotifications(IList<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(ICollection<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(IReadOnlyCollection<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public void AddNotifications(INotifiable notifiableItem)
        {
            _notifications.AddRange(notifiableItem.Notifications);
        }

        public void AddNotifications(params INotifiable[] notifiableItems)
        {
            foreach (var item in notifiableItems)
                _notifications.AddRange(item.Notifications);
        }

        public abstract void Validate();

        #endregion
    }
}
