using System;

namespace Notificator.Validations.Rules
{
    internal class DateTimeBetweenRule : IRule
    {
        public DateTimeBetweenRule(DateTime value, DateTime minDate, DateTime maxDate, bool inclusive, string notificationKey, string notificationMessage)
        {
            _value = value;
            _minDate = minDate;
            _maxDate = maxDate;
            _inclusive = inclusive;
            NotificationKey = notificationKey;
            NotificationMessage = notificationMessage;
        }

        private DateTime _value;
        private DateTime _minDate;
        private DateTime _maxDate;
        private bool _inclusive;
        public string NotificationKey { get; }
        public string NotificationMessage { get; }

        public bool Validate()
        {
            if (_inclusive)
                return _value >= _minDate && _value <= _maxDate;

            return _value > _minDate && _value < _maxDate;
        }
    }
}
