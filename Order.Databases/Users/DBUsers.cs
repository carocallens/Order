using Order.Domain.Users;
using System.Collections.Generic;
using Order.Domain.Users.Properties;

namespace Order.Databases.Users
{
    public static class DBUsers
    {
        public static List<User> Users = new List<User>() {
            UserBuilder.CreateUser()
            .WithFirstName("Caroline")
            .WithLastName("Callens")
            .WithEmail("user@user.com")
            .WithPassword("Password123")
            .WithRole(Role.admin)
            .WithAddress(new Address("Van Kerckhovenstraat", "14/201", 2800, "Mechelen"))
            .WithPhoneNumber("0478536637")
            .Build(),

            UserBuilder.CreateUser()
            .WithFirstName("MM")
            .WithLastName("DD")
            .WithEmail("user1@user.com")
            .WithPassword("Password123")
            .WithAddress(new Address("Pastoriestraat", "39A", 1651, "Lot"))
            .WithPhoneNumber("lalaa")
            .Build()
        };
    }
}
