using System.Text.RegularExpressions;

namespace Notificatr.Validations.Rules
{
    internal class StringRegexRule : IRule
    {
        public StringRegexRule(string input, string pattern, string notificationKey, string notificationMessage, RegexOptions options)
        {
            _input = input;
            _pattern = pattern;
            NotificationKey = notificationKey;
            NotificationMessage = notificationMessage;
            _options = options;
        }

        private string _input;
        private string _pattern;
        private RegexOptions _options;

        public string NotificationKey { get; }
        public string NotificationMessage { get; }

        public bool Validate()
        {
            if (string.IsNullOrEmpty(_pattern))
                return false;

            return Regex.IsMatch(_input, _pattern, _options);
        }
    }
}
