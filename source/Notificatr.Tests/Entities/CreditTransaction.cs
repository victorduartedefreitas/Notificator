using Notificator.Tests.Enums;

namespace Notificator.Tests.Entities
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
