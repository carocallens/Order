using System;
using System.Collections.Generic;
using System.Text;
using Order.Domain.Items;

namespace Order.Services.ItemServices.Interfaces
{
    public interface IItemService
    {
        void CreateItem(Item item);
        List<Item> GetAll();
    }
}
