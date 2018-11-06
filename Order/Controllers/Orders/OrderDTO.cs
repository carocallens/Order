using Order.Domain.Items;
using System;
using System.Collections.Generic;

namespace Order.API.Controllers.Orders
{
    public class OrderDTO
    {
        public List<ItemGroup> ItemGroups { get; set; }
        public Guid CustomerID { get; set; }
    }
}
