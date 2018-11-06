using Microsoft.AspNetCore.Mvc;
using Order.API.Controllers.Items.Interfaces;
using Order.Domain.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.API.Controllers.Items
{
    public class ItemMapper : IItemMapper
    {
        public Item ItemDTOToItem(ItemDTO itemDTO)
        {
            return new Item(itemDTO.Name, itemDTO.Description, itemDTO.Price, itemDTO.Amount);
        }

        public List<ItemDTO> ItemListToItemDTOList(List<Item> items)
        {
            List<ItemDTO> itemDTOs = new List<ItemDTO>();

            foreach(var item in items)
            {
                itemDTOs.Add(new ItemDTO
                {
                    Name = item.Name,
                    Description = item.Description,
                    Price = item.Price,
                    Amount = item.Amount
                });
            }

            return itemDTOs;
        }
    }
}
