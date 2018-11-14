using Order.API.Controllers.Items;
using Order.API.Controllers.Orders.ItemGroups;
using System;
using System.Collections.Generic;

namespace Order.API.Controllers.Orders
{
    public class OrderRequestDTO
    {
        public string CustomerID { get; set; }
        public List<ItemGroupResponseDTO> OrderedItemGroups {get; set;}
    }
}
