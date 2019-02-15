namespace Notificator.Validations.Rules
{
    internal class BooleanRule : IRule
    {
        public BooleanRule(bool valueToEvaluate, bool referenceValue, string notificationKey, string notificationMessage)
        {
            _valueToEvaluate = valueToEvaluate;
            _referenceValue = referenceValue;
            NotificationKey = notificationKey;
            NotificationMessage = notificationMessage;
        }

        private bool _valueToEvaluate;
        private bool _referenceValue;
        public string NotificationKey { get; }
        public string NotificationMessage { get; }

        public bool Validate()
        {
            return _valueToEvaluate == _referenceValue;
        }
    }
}
