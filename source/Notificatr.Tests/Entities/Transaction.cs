using Notificatr.Notifications;
using Notificatr.Tests.Enums;
using System;

namespace Notificatr.Tests.Entities
{
    public class Transaction : NotifiableEntity
    {
        public Guid TransactionId { get; set; }
        public ETransactionType TransactionType { get; set; }
        public double Value { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
