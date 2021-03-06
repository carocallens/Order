﻿using Order.Databases.Users;
using Order.Domain.Users;
using Order.Services.UserServices;
using Order.Services.UserServices.Interfaces;
using Xunit;

namespace Order.Services.Tests.UserServices
{
    public class UserServiceTests
    {
        IUserService userService;

        public UserServiceTests()
        {
            DBUsers.Users.Clear();

            DBUsers.Users.Add(UserBuilder.CreateUser()
                .WithFirstName("Jean")
                .WithLastName("Jean")
                .WithEmail("user@user.com")
                .WithAddress(new Address("Papenhofstraat","30", 2800, "Mechelen"))
                .WithPhoneNumber("0478536637")
                .Build());
            DBUsers.Users.Add(
                UserBuilder.CreateUser()
                .WithFirstName("Pierre")
                .WithLastName("Pierre")
                .WithEmail("user1@user.com")
                .WithAddress(new Address("Cantersteen", "10", 1000, "Brussel"))
                .WithPhoneNumber("0472231802")
                .Build());

            userService = new UserService();
        }

        [Fact]
        public void GivenUserDatabaseWithTwoUsers_WhenCreateUser_ThenDatabaseUserCount3()
        {
            var user = UserBuilder.CreateUser()
                .WithFirstName("NewUser")
                .WithLastName("Pierre")
                .WithEmail("user1@user.com")
                .WithAddress(new Address("Kersbeeklaan", "26", 1190, "Brussel"))
                .WithPhoneNumber("0475926895")
                .Build();

            userService.CreateUser(user);

            Assert.Equal(3, DBUsers.Users.Count);
        }
    }
}
