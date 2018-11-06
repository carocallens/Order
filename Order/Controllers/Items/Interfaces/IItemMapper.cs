using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Order.Domain.Items;

namespace Order.API.Controllers.Items.Interfaces
{
    public interface IItemMapper
    {
        List<ItemDTO> ItemListToItemDTOList(List<Item> items);
        Item ItemDTOToItem(ItemDTO itemDTO);
    }
}
