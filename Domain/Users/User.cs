using Order.Domain.Users.Properties;
using System;

namespace Order.Domain.Users
{
    public class User
    {
        public Guid ID { get; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; set; }
        public Role UserRole { get; set; }
        public Address Address { get; private set; }
        public string PhoneNumber { get; private set; }

        public User(UserBuilder userBuilder)
        {
            ID = Guid.NewGuid();
            FirstName = userBuilder.FirstName;
            LastName = userBuilder.LastName;
            Email = userBuilder.Email;
            Password = userBuilder.Password;
            UserRole = userBuilder.UserRole;
            Address = userBuilder.Address;
            PhoneNumber = userBuilder.PhoneNumber;
        }
    }
}
