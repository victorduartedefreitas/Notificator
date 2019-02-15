namespace Notificator.Validations.Rules
{
    internal class StringContainsRule : IRule
    {
        public StringContainsRule(string value, string contains, string notificationKey, string notificationMessage)
        {
            _value = value;
            _contains = contains;
            NotificationKey = notificationKey;
            NotificationMessage = notificationMessage;
        }

        private string _value;
        private string _contains;

        public string NotificationKey { get; }
        public string NotificationMessage { get; }

        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(_value) && !string.IsNullOrWhiteSpace(_contains) && _value.Contains(_contains);
        }
    }
}
