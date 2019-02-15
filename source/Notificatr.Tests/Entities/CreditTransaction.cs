using Notificatr.Tests.Enums;

namespace Notificatr.Tests.Entities
{
    public class CreditTransaction : Transaction
    {
        public CreditTransaction() : base(ETransactionType.Credit) { }

        public CreditTransaction(double value) : base(ETransactionType.Credit)
        {
            Value = value;
        }
    }
}
