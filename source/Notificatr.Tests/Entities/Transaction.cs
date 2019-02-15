using Notificatr.Notifications;
using Notificatr.Tests.Enums;
using System;

namespace Notificatr.Tests.Entities
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
