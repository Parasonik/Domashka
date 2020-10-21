using System;
using System.Collections.Generic;
using System.Text;

namespace Big_Domashka
{
    public class Order
    {
        public Guid id = Guid.NewGuid();
        public DateTime dateOfOrder = DateTime.Now;
        public Guid buyerId { get; set; }
        public List<OrderItem> listOfOrderItems = new List<OrderItem>();

    }
}
