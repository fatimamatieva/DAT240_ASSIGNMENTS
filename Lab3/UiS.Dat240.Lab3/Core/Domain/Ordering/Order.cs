
using System;
using System.Collections.Generic;
using System.Linq;
using UiS.Dat240.Lab3.SharedKernel;
namespace UiS.Dat240.Lab3.Core.Domain.Ordering
{
    public class Order : BaseEntity
    {
        public Order(Location location, Customer customer, string Notes )
        {
            OrderDate = DateTime.Now;

        }

        public Order()
        {
        }

        public int Id { get; protected set; }

        private readonly List<OrderLine> _orderLines = new();
        public IEnumerable<OrderLine> OrderLines => _orderLines.AsReadOnly();
        public DateTime OrderDate
        {
            get; set;
        }
        public Location Location
        {
            get; set;
        }
        public string Notes
        {
            get; set;
        }
        public Customer Customer
        {
            get; set;
        }
        public Status Status { get; set; }

        

        public void AddOrderLine(Guid itemId, decimal itemPrice, int count)
        {
            var item = _orderLines.SingleOrDefault(item => item.Item == itemId);
            if (item == null)
            {
                item = new(itemId, itemPrice, count);
                _orderLines.Add(item);
                return;
            }
        }

        

        
    }
}