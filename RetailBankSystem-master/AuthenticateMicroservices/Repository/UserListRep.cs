using AuthenticateMicroservices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AuthenticateMicroservices.Repository
{
    public class UserListRep : IUserListRep
    {
        public static List<User> userList = new List<User>
            {
                new User{UserId=1,Password="1234",Roles="Employee"},
                new User{UserId=1,Password="12345",Roles="Customer"}
            };

        public IEnumerable<User> getUserList()
        {
            
            return userList;
        }

        public void AddUser(User u)
        {
            userList.Add(u);
        }
    }
}
