﻿using System;

namespace Order.Domain.Items
{
    public class ItemGroup
    {
        public Guid ItemID { get; private set; }
        public int OrderedAmount { get; private set; }
        public decimal Price { get; private set; }
        public DateTime ShippingDate { get; private set; }

        public ItemGroup(Guid itemID, int orderedAmount, decimal price)
        {
            ItemID = itemID;
            OrderedAmount = orderedAmount;
            Price = price;
        }

        public void DetermineShippingDate(int stockAmount)
        {
            if (stockAmount - OrderedAmount > 0)
            {
                ShippingDate = DateTime.Now.AddDays(1);
            }
            else
            {
                ShippingDate = DateTime.Now.AddDays(7);
            }
        }
    }
}
