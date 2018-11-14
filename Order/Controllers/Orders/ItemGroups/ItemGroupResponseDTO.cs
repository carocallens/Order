using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.API.Controllers.Orders.ItemGroups
{
    public class ItemGroupResponseDTO
    {
        public Guid ItemID { get; set; }
        public int OrderedAmount { get; set; }
    }
}
