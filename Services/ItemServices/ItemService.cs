using Order.Databases.Items;
using Order.Domain.Items;
using Order.Services.ItemServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order.Services.ItemServices
{
    public class ItemService : IItemService
    {
        public void CreateItem(Item item)
        {
            DBItems.Items.Add(item.ID, item);
        }

        public List<Item> GetAll()
        {
            return DBItems.Items.Values.ToList();
        }

        public Item GetItem(Guid itemID)
        {
            return DBItems.Items.FirstOrDefault(item => item.Key == itemID).Value;
        }
    }
}
