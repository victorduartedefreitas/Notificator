using System;

namespace Notificator.Notifications
{
    public class Notification
    {
        #region Properties

        /// <summary>
        /// Key of notification
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// Message of notification
        /// </summary>
        public string Message { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new Notification Instance
        /// </summary>
        /// <param name="key">key of notification</param>
        /// <param name="message">message of notification</param>
        public Notification(string key, string message)
        {
            Key = key ?? throw new ArgumentNullException(nameof(key));
            Message = message ?? throw new ArgumentNullException(nameof(message));
        }

        #endregion
    }
}
