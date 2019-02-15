namespace Notificator.Validations.Rules
{
    internal class ByteEqualsRule : IRule
    {
        public ByteEqualsRule(byte value, byte compareTo, bool equals, string notificationKey, string notificationMessage)
        {
            _value = value;
            _compareTo = compareTo;
            _equals = equals;
            NotificationKey = notificationKey;
            NotificationMessage = notificationMessage;
        }

        private byte _value;
        private byte _compareTo;
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
