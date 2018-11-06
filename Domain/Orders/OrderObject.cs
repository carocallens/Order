using Order.Domain.Items;
using Order.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Order.Domain.Orders
{
    public class OrderObject
    {
        public Guid ID { get; }
        public List<ItemGroup> ItemGroups { get; private set; }
        public Guid CustomerID { get; private set; }

        public OrderObject(List<ItemGroup> itemGroups, Guid customerID)
        {
            ID = new Guid();
            ItemGroups = itemGroups;
            CustomerID = customerID;
        }
    }
}
