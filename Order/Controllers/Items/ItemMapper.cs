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
        public Item ItemDTOToItem(ItemRequestDTO itemDTO)
        {
            return new Item(itemDTO.Name, itemDTO.Description, itemDTO.Price, itemDTO.Amount);
        }

        public List<ItemResponseDTO> ItemListToItemDTOList(List<Item> items)
        {
            List<ItemResponseDTO> itemDTOs = new List<ItemResponseDTO>();

            foreach(var item in items)
            {
                itemDTOs.Add(new ItemResponseDTO
                {
                    ID = item.ID,
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
