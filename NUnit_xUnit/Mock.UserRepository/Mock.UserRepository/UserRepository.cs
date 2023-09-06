using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock.UserRepository
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> FindAll() 
        { return null; }
    }
}
