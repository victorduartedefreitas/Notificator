﻿using Notificator.Tests.Validators;
using System;
using System.Collections.Generic;

namespace Notificator.Tests.Entities
{
    public class Account : NotifiableEntity<IAccount, AccountValidator>, IAccount
    {
        public Guid AccountId { get; set; }
        public Guid CustomerId { get; set; }
        public IList<Transaction> Transactions { get; set; }
        public double Balance => GetBalance();

        public Account(Guid customerId)
        {
            Transactions = new List<Transaction>();
            CustomerId = customerId;
        }

        private void _validator_OnValidated(object sender, EventArgs e)
        {
        }

        private double GetBalance()
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

        public void Withdraw(double amount)
        {
            Withdraw(new DebitTransaction(amount));
        }

        public void Withdraw(DebitTransaction transaction)
        {
            Transactions.Add(transaction);
        }

        public void Deposit(double amount)
        {
            Deposit(new CreditTransaction(amount));
        }

        public void Deposit(CreditTransaction transaction)
        {
            Transactions.Add(transaction);
        }
    }
}
