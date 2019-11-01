namespace Notificator.Validations.Rules
{
    public interface IRule
    {
        string NotificationKey { get; }
        string NotificationMessage { get; }

        bool Validate();
    }
}
