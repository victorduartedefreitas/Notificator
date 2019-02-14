using System;

namespace Notificatr.Notifications
{
    public class Notification
    {
        #region Properties

        public string Key { get; set; }
        public string Message { get; set; }

        #endregion

        #region Constructors

        public Notification(string key, string message)
        {
            Key = key ?? throw new ArgumentNullException(nameof(key));
            Message = message ?? throw new ArgumentNullException(nameof(message));
        }

        #endregion
    }
}
