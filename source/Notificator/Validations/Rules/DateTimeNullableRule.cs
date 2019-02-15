using System;

namespace Notificator.Validations.Rules
{
    internal class DateTimeNullableRule : IRule
    {
        public DateTimeNullableRule(DateTime? value, bool nullable, string notificationKey, string notificationMessage)
        {
            _value = value;
            _nullable = nullable;
            NotificationKey = notificationKey;
            NotificationMessage = notificationMessage;
        }

        private DateTime? _value;
        private bool _nullable;
        public string NotificationKey { get; }
        public string NotificationMessage { get; }

        public bool Validate()
        {
            if (_nullable)
                return _value == null || !_value.HasValue;

            return _value.HasValue;
        }
    }
}
