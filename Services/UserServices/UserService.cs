using Order.Databases.Users;
using Order.Domain.Users;
using Order.Services.UserServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Services.UserServices
{
    public class UserService : IUserService
    {
        public async Task<User> Authenticate(string username, string password)
        {
            var user = await Task.Run(() => DBUsers.Users.SingleOrDefault(x => x.Email == username && x.Password == password));

            if (user == null)
                return null;

            user.Password = null;
            return user;
        }

        public void CreateUser(User user)
        {
            DBUsers.Users.Add(user);
        }

        public List<User> GetAll()
        {
            return DBUsers.Users;
        }

        public User GetCustomer(Guid customerID)
        {
            return DBUsers.Users.FirstOrDefault(user => user.ID == customerID);
        }
    }
}
