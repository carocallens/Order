using Order.Domain.Users.Properties;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Domain.Users
{
    public class UserBuilder
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role UserRole { get; set; }
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }

        private UserBuilder()
        {
        }

        public static UserBuilder CreateUser()
        {
            return new UserBuilder();
        }

        public UserBuilder WithFirstName(string firstname)
        {
            FirstName = firstname;
            return this;
        }

        public UserBuilder WithLastName(string lastName)
        {
            LastName = lastName;
            return this;
        }
        
        public UserBuilder WithEmail(string email)
        {
            Email = email;
            return this;
        }

        public UserBuilder WithPassword(string password)
        {
            Password = password;
            return this;
        }

        public UserBuilder WithAddress(Address address)
        {
            Address = address;
            return this;
        }
        
        public UserBuilder WithRole(Role userRole = Role.customer)
        {
            UserRole = userRole;
            return this;
        }

        public UserBuilder WithPhoneNumber(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
            return this;
        }

        public User Build()
        {
            return new User(this);
        }
    }
}
