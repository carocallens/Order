using Order.API.Controllers.ItemGroups;
using Order.API.Controllers.Items;
using Order.API.Controllers.Orders.Interfaces;
using Order.Domain.Items;
using Order.Domain.Orders;
using Order.Domain.Users;
using Order.Services.UserServices;
using Order.Services.UserServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.API.Controllers.Orders
{
    public class OrderMapper : IOrderMapper
    {
        IUserService userService = new UserService();
        ItemGroupMapper itemgroupMapper = new ItemGroupMapper();

        public OrderObject OrderRequestDTOtoOrder(OrderRequestDTO orderDTO)
        {
            User customer = userService.GetCustomer(orderDTO.CustomerID);

            List<ItemGroup> itemGroups = new List<ItemGroup>();
            foreach(var itemgroup in orderDTO.OrderedItemGroups)
            {
                itemGroups.Add(itemgroupMapper.ItemGroupDTOToItemGroup(itemgroup));
            }

            return new OrderObject(itemGroups, customer.ID);
        }

        public OrderResponseDTO OrderToOrderResponseDTOWithPrice(OrderObject order, decimal price)
        {
            List<ItemGroupRequestDTO> itemGroups = ItemGroupListToItemGroupDTOList(order);
            return new OrderResponseDTO { ItemGroupDTOs = itemGroups, TotalPrice = price };
        }


        public OrderDTO OrderToOrderDTO(OrderObject order)
        {
            return new OrderDTO { ItemGroups = order.ItemGroups, CustomerID = order.CustomerID };
        }

        public List<OrderDTO> ListOrdersToListOrderDTOs(List<OrderObject> orders)
        {
            List<OrderDTO> orderDTOs = new List<OrderDTO>();

            foreach(var order in orders)
            {
                orderDTOs.Add(OrderToOrderDTO(order));
            }

            return orderDTOs;
        }

        private List<ItemGroupRequestDTO> ItemGroupListToItemGroupDTOList(OrderObject order)
        {
            List<ItemGroupRequestDTO> itemGroups = new List<ItemGroupRequestDTO>();
            foreach (var itemgroup in order.ItemGroups)
            {
                itemGroups.Add(itemgroupMapper.ItemGroupToItemGroupDTO(itemgroup));
            }

            return itemGroups;
        }
    }
}
