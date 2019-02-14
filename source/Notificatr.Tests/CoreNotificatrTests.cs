using Notificatr.Tests.Entities;
using System;
using Xunit;

namespace Notificatr.Tests
{
    public class CoreNotificatrTests
    {
        [Fact]
        public void Test1()
        {
            Customer customer = new Customer();
            customer.Address = "Rua de teste";

            customer.Validate();
        }
    }
}
