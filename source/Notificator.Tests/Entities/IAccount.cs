using Notificator.Core;
using System;
using System.Collections.Generic;

namespace Notificator.Tests.Entities
{
    public interface IAccount : INotifiable
    {
        Guid AccountId { get; set; }
        Guid CustomerId { get; set; }
        IList<Transaction> Transactions { get; set; }
        double Balance { get; }
    }
}
