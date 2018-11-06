using Order.Databases.Orders;
using Order.Domain.Orders;
using Order.Services.ItemServices;
using Order.Services.ItemServices.Interfaces;
using Order.Services.OrderServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order.Services.OrderServices
{
    public class OrderService : IOrderService
    {
        public IItemService itemService;

        public OrderService(IItemService itemService)
        {
            this.itemService = itemService;
        }

        public List<OrderObject> GetAll()
        {
            return DBOrders.Orders;
        }

        public decimal Order(OrderObject orderObject)
        {
            DetermineShippingDateForItemGroups(orderObject);
            DBOrders.Orders.Add(orderObject);

            return CalculatePriceOrder(orderObject);
        }

        private void DetermineShippingDateForItemGroups(OrderObject orderObject)
        {
            foreach (var itemgroup in orderObject.ItemGroups)
            {
                var item = itemService.GetItem(itemgroup.ItemID);
                itemgroup.DetermineShippingDate(item.Amount);
            }
        }

        private decimal CalculatePriceOrder(OrderObject orderObject)
        {
            return orderObject.ItemGroups.Sum(itemgr => itemgr.Price);
        }
    }
}
