using Notificator.Notifications;
using Notificator.Tests.Enums;
using System;

namespace Notificator.Tests.Entities
{
    public class Transaction : NotifiableEntity
    {
        public Guid TransactionId { get; set; }
        public ETransactionType TransactionType { get; private set; }
        public double Value { get; set; }

        public Transaction() : this(ETransactionType.Credit)
        {
        }

        public Transaction(ETransactionType transactionType)
        {
            TransactionType = transactionType;
        }

        protected override void DoValidate()
        {
            throw new NotImplementedException();
        }
    }
}
