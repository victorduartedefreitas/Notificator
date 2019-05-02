using Notificator.Notifications;
using System;

namespace Notificator.Tests.Entities
{
    public interface ICustomer : INotifiable
    {
        Guid CustomerId { get; set; }
        string FullName { get; set; }
        string Address { get; set; }
        string Document { get; set; }
    }
}
