using Order.Databases.Orders;
using Order.Domain.Orders;
using Order.Services.ItemServices.Interfaces;
using Order.Services.OrderServices.Interfaces;
using System.Collections.Generic;
using System.Linq;

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

            ReduceAmountInItemDatabase(orderObject);

            return CalculatePriceOrder(orderObject);
        }

        private void ReduceAmountInItemDatabase(OrderObject orderObject)
        {
            foreach (var itemgroup in orderObject.ItemGroups)
            {
                itemService.GetItem(itemgroup.ItemID).ReduceAmount(itemgroup.OrderedAmount);
            }
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
