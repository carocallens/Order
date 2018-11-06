using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.API.Controllers.ItemGroups
{
    public class ItemGroupRequestDTO
    {
        public string ItemName { get; set; }
        public int AmountOfItems { get; set; }
        public decimal ItemGroupPrice { get; set; }
    }
}
