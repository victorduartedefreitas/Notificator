namespace Notificatr.Validations.Rules
{
    internal class StringNotNullOrWhiteSpaceRule : IRule
    {
        public StringNotNullOrWhiteSpaceRule(string text, bool nullable, string notificationKey, string notificationMessage)
        {
            _text = text;
            _nullable = nullable;
            NotificationKey = notificationKey;
            NotificationMessage = notificationMessage;
        }

        private string _text;
        private bool _nullable;

        public string NotificationKey { get; private set; }
        public string NotificationMessage { get; private set; }

        public bool Validate()
        {
            if (_nullable)
                return string.IsNullOrWhiteSpace(_text);

            return !string.IsNullOrWhiteSpace(_text);
        }
    }
}
