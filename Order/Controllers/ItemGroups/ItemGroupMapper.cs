using Order.Domain.Items;
using Order.Services.ItemServices;
using Order.Services.ItemServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.API.Controllers.ItemGroups
{
    public class ItemGroupMapper
    {
        IItemService itemService = new ItemService();

        public ItemGroup ItemGroupDTOToItemGroup(ItemGroupResponseDTO itemGroupDTO)
        {
            Item item = itemService.GetItem(itemGroupDTO.ItemID);
            decimal priceItemGroup = item.Price * itemGroupDTO.OrderedAmount;

            return new ItemGroup(item.ID, itemGroupDTO.OrderedAmount, priceItemGroup);
        }

        public ItemGroupRequestDTO ItemGroupToItemGroupDTO(ItemGroup itemGroup)
        {
            return new ItemGroupRequestDTO
            {
                ItemName = itemService.GetItem(itemGroup.ItemID).Name,
                AmountOfItems = itemGroup.OrderedAmount,
                ItemGroupPrice = itemGroup.Price
            };
        }
    }
}
