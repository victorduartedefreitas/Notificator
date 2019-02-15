using System.Collections.Generic;

namespace Notificator.Notifications
{
    public interface INotifiable
    {
        #region Properties

        IReadOnlyCollection<Notification> Notifications { get; }
        bool IsValid { get; }

        #endregion

        #region Methods

        void AddNotification(string key, string message);
        void AddNotification(Notification notification);
        void AddNotifications(IList<Notification> notifications);
        void AddNotifications(ICollection<Notification> notifications);
        void AddNotifications(IReadOnlyCollection<Notification> notifications);
        void AddNotifications(INotifiable notifiableItem);
        void AddNotifications(params INotifiable[] notifiableItems);
        void Validate();

        #endregion
    }
}
