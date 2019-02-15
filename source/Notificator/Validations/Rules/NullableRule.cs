namespace Notificator.Validations.Rules
{
    internal class NullableRule : IRule
    {
        public NullableRule(object instance, bool nullable, string notificationKey, string notificationMessage)
        {
            _instance = instance;
            _nullable = nullable;
            NotificationKey = notificationKey;
            NotificationMessage = notificationMessage;
        }

        private object _instance;
        private bool _nullable;

        public string NotificationKey { get; private set; }
        public string NotificationMessage { get; private set; }

        public bool Validate()
        {
            if (_nullable)
                return _instance == null;

            return _instance != null;
        }
    }
}
