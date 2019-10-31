using System;

namespace Notificator.Tests.Entities
{
    public class Customer : NotifiableEntity, ICustomer
    {
        public Guid CustomerId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Document { get; set; }

        protected override void CreateValidationRules()
        {
            //ValidationInstance
            //    .IsNotNullOrEmpty(Entity.Address)
            //    .IsNotNullOrWhiteSpace(Entity.FullName)
            //    .HasMinLenght(Entity.FullName, 10)
            //    .HasMaxLenght(Entity.FullName, 100);
        }
    }
}
