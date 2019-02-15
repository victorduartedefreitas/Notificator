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
        public CustomRule(object[] parameters)
        {
        }

        /// <summary>
        /// Key od notification
        /// </summary>
        public abstract string NotificationKey { get; }
        /// <summary>
        /// Message of notification
        /// </summary>
        public abstract string NotificationMessage { get; }

        /// <summary>
        /// Validate the rule
        /// </summary>
        /// <returns></returns>
        public abstract bool Validate();
    }
}
