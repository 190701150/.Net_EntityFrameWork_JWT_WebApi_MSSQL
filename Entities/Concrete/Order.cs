using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Order:IEntity
    {
        public Order()
        {
        }
        public int OrderId { get; set; }

        public string CustomerId { get; set; }

        public int EmployeeId { get; set; }

        public DateTime OrderDate { get; set; }

        public string ShipCity { get; set; }
    }
}


