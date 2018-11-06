using Order.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Order.Services.UserServices.Interfaces
{
    public interface IUserService
    {
        void CreateUser(User user);
        List<User> GetAll();
        Task<User> Authenticate(string username, string password);
        User GetCustomer(Guid customerID);
    }
}
