using System;

namespace Notificator.Core
{
    public interface IEntityValidator<TEntity>
        where TEntity : INotifiable
    {
        event EventHandler OnValidated;
        void Validate();
    }
}
