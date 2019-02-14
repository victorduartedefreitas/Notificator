using Notificatr.Notifications;
using System;
using System.Collections.Generic;

namespace Notificatr.Tests.Entities
{
    public class Account : NotifiableEntity
    {
        public Guid AccountId { get; set; }
        public Guid CustomerId { get; set; }
        public IList<Transaction> Transactions { get; set; }

        public Account(Guid customerId)
        {
            Transactions = new List<Transaction>();
            CustomerId = customerId;
        }

        public double GetBalance()
        {
            double balance = 0.0d;

            foreach (var t in Transactions)
            {
                if (t.TransactionType == Enums.ETransactionType.Debit)
                    balance -= t.Value;
                else if (t.TransactionType == Enums.ETransactionType.Credit)
                    balance += t.Value;
            }

            return balance;
        }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
