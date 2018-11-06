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
            if (DBItems.Items.Any(dbItem => dbItem.Name == item.Name && dbItem.Price == item.Price))
            {
                DBItems.Items.FirstOrDefault(dbItem => dbItem.Name == item.Name).Amount += item.Amount;
            }
            else
            {
                DBItems.Items.Add(item);
            }
        }

        public List<Item> GetAll()
        {
            return DBItems.Items;
        }

        public Item GetItem(int itemID)
        {
            return DBItems.Items.FirstOrDefault(item => item.ObjectID == itemID);
        }
    }
}
