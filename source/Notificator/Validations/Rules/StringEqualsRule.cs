using System;

namespace Notificator.Validations.Rules
{
    internal class StringEqualsRule : IRule
    {
        public StringEqualsRule(string left, string right, bool validateEquals, string notificationKey, string notificationMessage, StringComparison comparison)
        {
            _left = left;
            _right = right;
            _areEquals = validateEquals;
            _comparison = comparison;

            NotificationKey = notificationKey;
            NotificationMessage = notificationMessage;
        }

        private string _left;
        private string _right;
        private bool _areEquals;
        private StringComparison _comparison;

        public string NotificationKey { get; private set; }
        public string NotificationMessage { get; private set; }

        public bool Validate()
        {
            if (_areEquals)
                return string.Equals(_left, _right, _comparison);

            return !string.Equals(_left, _right, _comparison);
        }
    }
}
