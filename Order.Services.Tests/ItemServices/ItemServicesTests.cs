using Order.Databases.Items;
using Order.Domain.Items;
using Order.Services.ItemServices;
using Order.Services.ItemServices.Interfaces;
using System.Linq;
using Xunit;

namespace Order.Services.Tests.ItemServices
{
    public class ItemServicesTests
    {
        IItemService itemService;

        public ItemServicesTests()
        {
            DBItems.Items.Clear();
            var itemKaas = new Item("Kaas", "Lekker", 5, 2);
            DBItems.Items.Add(itemKaas);
            var itemHesp = new Item("Hesp", "Ok", 4, 5);
            DBItems.Items.Add(itemHesp);

            itemService = new ItemService();
        }

        [Fact]
        public void GivenItemDatabaseWithTwoItems_WhenCreateItem_ThenDatabaseItemCount3()
        {
            var item = new Item("Dopperfles", "Ecological and green", 15, 1);

            itemService.CreateItem(item);

            Assert.Equal(3, DBItems.Items.Count);
        }
    }
}
