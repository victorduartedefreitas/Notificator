﻿namespace Notificator.Validations.Rules
{
    internal class FloatGreaterThanOrEqualsRule : IRule
    {
        public FloatGreaterThanOrEqualsRule(float value, float compareTo, bool validateEquals, bool greaterThan, string notificationKey, string notificationMessage)
        {
            _value = value;
            _compareTo = compareTo;
            _validateEquals = validateEquals;
            _greaterThan = greaterThan;
            NotificationKey = notificationKey;
            NotificationMessage = notificationMessage;
        }

        private float _value;
        private float _compareTo;
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