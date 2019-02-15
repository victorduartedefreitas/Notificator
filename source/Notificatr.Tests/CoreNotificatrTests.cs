using Notificatr.Notifications;
using Notificatr.Tests.Entities;
using System;
using System.Collections.Generic;
using Xunit;

namespace Notificatr.Tests
{
    public class CoreNotificatrTests
    {
        [Fact]
        public void AccountNegativeBalanceValidationTest()
        {
            Account account = new Account(Guid.NewGuid());

            account.Deposit(100);
            account.Withdraw(150);
            account.Deposit(2500);
            account.Withdraw(3000);

            var balance = account.Balance;

            account.Validate();

            bool isValid = account.IsValid;
            var notifications = new List<Notification>();
            notifications.AddRange(account.Notifications);

            Assert.False(isValid);
            Assert.True(notifications.Count == 1);
            Assert.True(notifications[0].Key == "BalanceGreaterThanZeroCustomRuleViolation");
        }

        [Fact]
        public void CustomerFullNameMinLenghtValidationTest()
        {
            Customer customer = new Customer
            {
                FullName = "nome",
                Address = "Rua de teste, 1",
                CustomerId = Guid.NewGuid(),
                Document = "123.456.789.00"
            };

            customer.Validate();
            var notifications = new List<Notification>(customer.Notifications);

            Assert.False(customer.IsValid);
            Assert.Contains(customer.Notifications, f => f.Key == "HasMinLenghtRuleViolation");
        }

        [Fact]
        public void CustomerValidTest()
        {
            Customer customer = new Customer
            {
                FullName = "nome completo da pessoa",
                Address = "Rua de teste, 2",
                CustomerId = Guid.NewGuid(),
                Document = "123.456.789.00"
            };

            customer.Validate();

            Assert.True(customer.IsValid);
        }
    }
}
