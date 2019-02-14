namespace Notificatr.Validations.Rules
{
    internal class Int64EqualsRule : IRule
    {
        public Int64EqualsRule(long value, long compareTo, bool equals, string notificationKey, string notificationMessage)
        {
            _value = value;
            _compareTo = compareTo;
            _equals = equals;
            NotificationKey = notificationKey;
            NotificationMessage = notificationMessage;
        }

        private long _value;
        private long _compareTo;
        private bool _equals;
        public string NotificationKey { get; }
        public string NotificationMessage { get; }

        public bool Validate()
        {
            if (_equals)
                return _value == _compareTo;

            return _value != _compareTo;
        }
    }
}
