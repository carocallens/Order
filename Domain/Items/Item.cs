using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain.Items
{
    public class Item
    {
        public Guid SystemID { get; }
        public int ObjectID { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Amount { get; set; }

        public Item(int id, string name, string description, decimal price, int amount)
        {
            SystemID = new Guid();
            ObjectID = id;
            Name = name;
            Description = description;
            Price = price;
            Amount = amount;
        }
    }
}
