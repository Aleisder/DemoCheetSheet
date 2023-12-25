using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using Demo.Model;

namespace Demo.Repository
{
    class UserRepository : Repository
    {

        public User? GetUserById(int id) => (User?)Context.Users.Where(it => it.Id == id);

        public List<User> GetAllUsers() => Context.Users.ToList();

    }
}
