using Order.API.Controllers.Users.Interfaces;
using Order.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.API.Controllers.Users
{
    public class UserMapper : IUserMapper
    {
        public User DTOToUser(UserDTO userDTO)
        {
            return UserBuilder.CreateUser()
                .WithFirstName(userDTO.FirstName)
                .WithLastName(userDTO.LastName)
                .WithEmail(userDTO.Email)
                .WithPassword(userDTO.Password)
                .WithRole()
                .WithStreet(userDTO.Street)
                .WithStreetNumber(userDTO.StreetNumber)
                .WithPostalCode(userDTO.PostalCode)
                .WithCity(userDTO.City)
                .WithPhoneNumber(userDTO.PhoneNumber)
                .Build();
        }

        public List<UserDTO> ListUsersToListUsersDTO(List<User> users)
        {
            List<UserDTO> userDTOs = new List<UserDTO>();
            foreach(var user in users)
            {
                userDTOs.Add(new UserDTO
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Password = user.Password,
                    Role = user.UserRole.ToString(),
                    Street = user.Street,
                    StreetNumber = user.StreetNumber,
                    PostalCode = user.PostalCode,
                    City = user.City,
                    PhoneNumber = user.PhoneNumber
                });
            }

            return userDTOs;
        }
    }
}
