namespace Notificatr.Validations.Rules
{
    /// <summary>
    /// Abstract class that allows you to implement custom rules for entity validations.
    /// </summary>
    public abstract class CustomRule : IRule
    {
        /// <summary>
        /// Constructor of CustomRule
        /// </summary>
        /// <param name="parameters">Parameters for the rule validation</param>
        public CustomRule(object[] parameters, string notificationKey, string notificationMessage)
        {
            Parameters = parameters;
            NotificationKey = notificationKey;
            NotificationMessage = notificationMessage;
        }

        /// <summary>
        /// Parameters of custom rule
        /// </summary>
        protected object[] Parameters { get; }

        /// <summary>
        /// Key od notification
        /// </summary>
        public string NotificationKey { get; }
        /// <summary>
        /// Message of notification
        /// </summary>
        public string NotificationMessage { get; }

        /// <summary>
        /// Validate the rule
        /// </summary>
        /// <returns></returns>
        public abstract bool Validate();
    }
}
