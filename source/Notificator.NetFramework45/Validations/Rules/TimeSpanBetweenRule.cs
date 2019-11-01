using System;

namespace Notificator.Validations.Rules
{
    internal class TimeSpanBetweenRule : IRule
    {
        public TimeSpanBetweenRule(TimeSpan value, TimeSpan minTimeSpan, TimeSpan maxTimeSpan, bool inclusive, string notificationKey, string notificationMessage)
        {
            _value = value;
            _minTimeSpan = minTimeSpan;
            _maxTimeSpan = maxTimeSpan;
            _inclusive = inclusive;
            NotificationKey = notificationKey;
            NotificationMessage = notificationMessage;
        }

        private TimeSpan _value;
        private TimeSpan _minTimeSpan;
        private TimeSpan _maxTimeSpan;
        private bool _inclusive;
        public string NotificationKey { get; }
        public string NotificationMessage { get; }

        public bool Validate()
        {
            if (_inclusive)
                return _value >= _minTimeSpan && _value <= _maxTimeSpan;

            return _value > _minTimeSpan && _value < _maxTimeSpan;
        }
    }
}
