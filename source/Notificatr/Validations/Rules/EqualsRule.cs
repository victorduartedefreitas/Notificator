namespace Notificatr.Validations.Rules
{
    internal class EqualsRule : IRule
    {
        public EqualsRule(object left, object right, bool validateEquals, string notificationKey, string notificationMessage)
        {
            _left = left;
            _right = right;
            _areEquals = validateEquals;
            NotificationKey = notificationKey;
            NotificationMessage = notificationMessage;
        }

        private object _left;
        private object _right;
        private bool _areEquals;

        public string NotificationKey { get; private set; }
        public string NotificationMessage { get; private set; }

        public bool Validate()
        {
            if (_areEquals)
                return _left.Equals(_right);

            return !_left.Equals(_right);
        }
    }
}
