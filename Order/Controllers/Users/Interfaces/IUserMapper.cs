using Order.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.API.Controllers.Users.Interfaces
{
    public interface IUserMapper
    {
        User DTOToUser(UserDTO userDTO);
        List<UserDTO> ListUsersToListUsersDTO(List<User> users);
    }
}
