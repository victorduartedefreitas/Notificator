using Notificator.Tests.Enums;
using Notificator.Tests.Validators;
using System;

namespace Notificator.Tests.Entities
{
    public class Transaction : NotifiableEntity<ITransaction, TransactionValidator>, ITransaction
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
    }
}
