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
        //private IEnumerable<User> FakeUsers
        //{
        //    get 
        //    {
        //        return new UserRepository<User>()
        //        {
        //            new User("Антон"),
        //            new User("Иван"),
        //            new User("Алексей")
        //        };
        //    }
        //}
    }
}
