using Notificator.Models;
using System.Collections.Generic;

namespace Notificator.Core
{
    public interface INotifiable
    {
        #region Properties

        /// <summary>
        /// All notifications
        /// </summary>
        IReadOnlyCollection<Notification> Notifications { get; }
        /// <summary>
        /// Identifies if the entity is valid
        /// </summary>
        bool IsValid { get; }

        #endregion

        #region Methods

        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="key">notification key</param>
        /// <param name="message">notification message</param>
        void AddNotification(string key, string message);
        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notification">notification</param>
        void AddNotification(Notification notification);
        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notifications">collection of notifications</param>
        void AddNotifications(IList<Notification> notifications);
        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notifications">collection of notifications</param>
        void AddNotifications(ICollection<Notification> notifications);
        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notifications">collection of notifications</param>
        void AddNotifications(IReadOnlyCollection<Notification> notifications);
        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notifiableItem">notifiable item</param>
        void AddNotifications(INotifiable notifiableItem);
        /// <summary>
        /// And error notification
        /// </summary>
        /// <param name="notifiableItems">array of notifiable items</param>
        void AddNotifications(params INotifiable[] notifiableItems);
        /// <summary>
        /// validate the entity
        /// </summary>
        void Validate();

        #endregion
    }
}
