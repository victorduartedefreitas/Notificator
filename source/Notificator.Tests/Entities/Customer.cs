using Notificator.Tests.Validators;
using System;

namespace Notificator.Tests.Entities
{
    public class Customer : NotifiableEntity<ICustomer, CustomerValidator>, ICustomer
    {
        public Guid CustomerId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Document { get; set; }
    }
}
