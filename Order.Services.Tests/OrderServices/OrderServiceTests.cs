using Order.Databases.Items;
using Order.Databases.Orders;
using Order.Databases.Users;
using Order.Domain.Items;
using Order.Domain.Orders;
using Order.Services.ItemServices;
using Order.Services.ItemServices.Interfaces;
using Order.Services.OrderServices;
using Order.Services.OrderServices.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Order.Services.Tests.OrderServices
{
    public class OrderServiceTests
    {
        IOrderService orderService;
        IItemService itemService;

        public OrderServiceTests()
        {
            DBOrders.Orders.Clear();
            itemService = new ItemService();
            orderService = new OrderService(itemService);
        }

        [Fact]
        public void GivenOrderDatabase_WhenCreateOrder_ThenOrderInDatabase()
        {
            var item1 = DBItems.Items.FirstOrDefault(item => item.Name == "iphone");
            var customerID = DBUsers.Users[1].ID;

            var price = orderService.Order(new OrderObject(new List<ItemGroup>() { new ItemGroup(item1.ID, 5, item1.Price * 5) }, customerID));

            Assert.Single(DBOrders.Orders);
        }
    }
}
