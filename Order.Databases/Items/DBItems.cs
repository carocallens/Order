using Order.Domain.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Databases.Items
{
    public class DBItems
    {
        public static List<Item> Items = new List<Item>()
        {
            new Item("iphone", "telefoon", 1000, 30),
            new Item("samsung", "andere telefoon", 300, 20)
        };
    }
}
