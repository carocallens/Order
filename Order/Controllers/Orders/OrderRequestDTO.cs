using Order.API.Controllers.ItemGroups;
using Order.API.Controllers.Items;
using System;
using System.Collections.Generic;

namespace Order.API.Controllers.Orders
{
    public class OrderRequestDTO
    {
        public Guid CustomerID { get; set; }
        public List<ItemGroupResponseDTO> OrderedItemGroups {get; set;}
    }
}
