namespace Notificator.Validations.Rules
{
    internal class StringMaxLenghtRule : IRule
    {
        public StringMaxLenghtRule(string value, int maxLenght, string notificationKey, string notificationMessage)
        {
            _text = value;
            _maxLenght = maxLenght;
            NotificationKey = notificationKey;
            NotificationMessage = notificationMessage;
        }

        private string _text;
        private int _maxLenght;

        public string NotificationKey { get; }
        public string NotificationMessage { get; }

        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(_text) && _text.Length <= _maxLenght;
        }
    }
}
