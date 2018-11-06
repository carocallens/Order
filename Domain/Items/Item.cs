using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain.Items
{
    public class Item
    {
        public Guid ID { get; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Amount { get; set; }

        public Item(string name, string description, decimal price, int amount)
        {
            ID = Guid.NewGuid();
            Name = name;
            Description = description;
            Price = price;
            Amount = amount;
        }
    }
}
