using Notificatr.Tests.Entities;
using Notificatr.Tests.Validators;
using System;
using Xunit;

namespace Notificatr.Tests
{
    public class CoreNotificatrTests
    {
        [Fact]
        public void Test1()
        {
            Account account = new Account(Guid.NewGuid());

            account.Deposit(100);
            account.Withdraw(150);
            account.Deposit(2500);
            account.Withdraw(3000);

            var balance = account.Balance;

            account.Validate();

            bool isValid = account.IsValid;
            var notifications = account.Notifications;
        }
    }
}
