using System;

namespace Notificator.Validations.Rules
{
    internal class TimeSpanGreaterThanOrEqualsRule : IRule
    {
        public TimeSpanGreaterThanOrEqualsRule(TimeSpan value, TimeSpan compareTo, bool greaterThan, bool equals, string notificationKey, string notificationMessage)
        {
            _value = value;
            _compareTo = compareTo;
            _greaterThan = greaterThan;
            _equals = equals;
            NotificationKey = notificationKey;
            NotificationMessage = notificationMessage;
        }

        private TimeSpan _value;
        private TimeSpan _compareTo;
        private bool _equals;
        private bool _greaterThan;
        public string NotificationKey { get; }
        public string NotificationMessage { get; }

        public bool Validate()
        {
            if (_greaterThan)
            {
                if (_equals)
                    return _value >= _compareTo;

                return _value > _compareTo;
            }
            else
            {
                if (_equals)
                    return _value <= _compareTo;

                return _value < _compareTo;
            }
        }
    }
}
