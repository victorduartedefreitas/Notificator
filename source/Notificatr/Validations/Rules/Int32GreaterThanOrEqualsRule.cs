﻿namespace Notificatr.Validations.Rules
{
    internal class Int32GreaterThanOrEqualsRule : IRule
    {
        public Int32GreaterThanOrEqualsRule(int value, int compareTo, bool validateEquals, bool greaterThan, string notificationKey, string notificationMessage)
        {
            _value = value;
            _compareTo = compareTo;
            _validateEquals = validateEquals;
            _greaterThan = greaterThan;
            NotificationKey = notificationKey;
            NotificationMessage = notificationMessage;
        }

        private int _value;
        private int _compareTo;
        private bool _validateEquals;
        private bool _greaterThan;
        public string NotificationKey { get; }
        public string NotificationMessage { get; }

        public bool Validate()
        {
            if (_greaterThan)
            {
                if (_validateEquals)
                    return _value >= _compareTo;

                return _value > _compareTo;
            }
            else
            {
                if (_validateEquals)
                    return _value <= _compareTo;

                return _value < _compareTo;
            }
        }
    }
}
