using Notificatr.Tests.Enums;

namespace Notificatr.Tests.Entities
{
    public class DebitTransaction : Transaction
    {
        public DebitTransaction() : base(ETransactionType.Debit) { }

        public DebitTransaction(double value) : base(ETransactionType.Debit)
        {
            Value = value;
        }
    }
}
