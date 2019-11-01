namespace Notificator.Validations.Rules
{
    internal class StringMinLenghtRule : IRule
    {
        public StringMinLenghtRule(string value, int minLenght, string notificationKey, string notificationMessage)
        {
            _text = value;
            _minLenght = minLenght;
            NotificationKey = notificationKey;
            NotificationMessage = notificationMessage;
        }

        private string _text;
        private int _minLenght;

        public string NotificationKey { get; }
        public string NotificationMessage { get; }

        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(_text) && _text.Length >= _minLenght;
        }
    }
}
