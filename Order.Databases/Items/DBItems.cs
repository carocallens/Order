using Order.Domain.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Databases.Items
{
    public static class DBItems
    {
        public static Dictionary<Guid, Item> Items = new Dictionary<Guid, Item>();
    }
}
