using Order.API.Controllers.ItemGroups;
using Order.API.Controllers.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.API.Controllers.Orders
{
    public class OrderResponseDTO
    {
        public List<ItemGroupRequestDTO> ItemGroupDTOs { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
