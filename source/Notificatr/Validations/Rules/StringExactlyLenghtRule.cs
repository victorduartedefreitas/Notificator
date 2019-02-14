namespace Notificatr.Validations.Rules
{
    internal class StringExactlyLenghtRule : IRule
    {
        public StringExactlyLenghtRule(string value, int lenght, string notificationKey, string notificationMessage)
        {
            _text = value;
            _lenght = lenght;
            NotificationKey = notificationKey;
            NotificationMessage = notificationMessage;
        }

        private string _text;
        private int _lenght;

        public string NotificationKey { get; }
        public string NotificationMessage { get; }

        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(_text) && _text.Length == _lenght;
        }
    }
}
