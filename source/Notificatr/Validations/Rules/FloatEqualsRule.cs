namespace Notificatr.Validations.Rules
{
    internal class FloatEqualsRule : IRule
    {
        public FloatEqualsRule(float value, float compareTo, bool equals, string notificationKey, string notificationMessage)
        {
            _value = value;
            _compareTo = compareTo;
            _equals = equals;
            NotificationKey = notificationKey;
            NotificationMessage = notificationMessage;
        }

        private float _value;
        private float _compareTo;
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
