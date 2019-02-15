namespace Notificator.Validations.Rules
{
    internal class UInt32EqualsRule : IRule
    {
        public UInt32EqualsRule(uint value, uint compareTo, bool equals, string notificationKey, string notificationMessage)
        {
            _value = value;
            _compareTo = compareTo;
            _equals = equals;
            NotificationKey = notificationKey;
            NotificationMessage = notificationMessage;
        }

        private uint _value;
        private uint _compareTo;
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
