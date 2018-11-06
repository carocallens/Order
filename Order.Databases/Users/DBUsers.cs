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
            .WithStreet("Van Kerckhovenstraat")
            .WithStreetNumber("14/201")
            .WithPostalCode(2800)
            .WithCity("Mechelen")
            .WithPhoneNumber("0478536637")
            .Build()};
    }
}
