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
                .WithAddress(new Address(userDTO.Street, userDTO.StreetNumber, userDTO.PostalCode, userDTO.City))
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
                    ID = user.ID.ToString(),
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Password = user.Password,
                    Role = user.UserRole.ToString(),
                    Street = user.Address.Street,
                    StreetNumber = user.Address.StreetNumber,
                    PostalCode = user.Address.PostalCode,
                    City = user.Address.City,
                    PhoneNumber = user.PhoneNumber
                });
            }

            return userDTOs;
        }
    }
}
