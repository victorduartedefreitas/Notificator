using System;

namespace Notificator.Validations.Rules
{
    internal class DateTimeGreaterThanOrEqualsRule : IRule
    {
        public DateTimeGreaterThanOrEqualsRule(DateTime value, DateTime compareTo, bool greaterThan, bool equals, string notificationKey, string notificationMessage)
        {
            _value = value;
            _compareTo = compareTo;
            _greaterThan = greaterThan;
            _equals = equals;
            NotificationKey = notificationKey;
            NotificationMessage = notificationMessage;
        }

        private DateTime _value;
        private DateTime _compareTo;
        private bool _greaterThan;
        private bool _equals;
        public string NotificationKey { get; }
        public string NotificationMessage { get; }

        public bool Validate()
        {
            if (_equals)
            {
                if (_greaterThan)
                    return _value >= _compareTo;

                return _value <= _compareTo;
            }
            else
            {
                if (_greaterThan)
                    return _value > _compareTo;

                return _value < _compareTo;
            }
        }
    }
}
