using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Order.API.Controllers.Users.Interfaces;
using Order.Domain.Users;
using Order.Services.UserServices;
using Order.Services.UserServices.Interfaces;
using System.Collections.Generic;

namespace Order.API.Controllers.Users
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IUserMapper _userMapper;

        public UsersController(IUserService userService, IUserMapper userMapper)
        {
            _userService = userService;
            _userMapper = userMapper;
        }

        //[Authorize(Policy = "RequireAdministratorRole")]
        [HttpGet]
        public ActionResult<List<UserDTO>> GetAll()
        {
            return Ok(_userMapper.ListUsersToListUsersDTO(_userService.GetAll()));
        }

        //[AllowAnonymous]
        [HttpPost]
        public ActionResult<User> CreateUser([FromBody]UserDTO userDTO)
        {
            _userService.CreateUser(_userMapper.DTOToUser(userDTO));

            return Ok();
        }
    }
}