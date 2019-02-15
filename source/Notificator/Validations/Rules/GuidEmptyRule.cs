using System;

namespace Notificator.Validations.Rules
{
    internal class GuidEmptyRule : IRule
    {
        public GuidEmptyRule(Guid value, bool empty, string notificationKey, string notificationMessage)
        {
            _value = value;
            _empty = empty;
            NotificationKey = notificationKey;
            NotificationMessage = notificationMessage;
        }

        private Guid _value;
        private bool _empty;
        public string NotificationKey { get; }
        public string NotificationMessage { get; }

        public bool Validate()
        {
            if (_empty)
                return _value == Guid.Empty;

            return _value != Guid.Empty;
        }
    }
}
