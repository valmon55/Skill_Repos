using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock.UserRepository
{
    public interface IUserRepository
    {
        IEnumerable<User> FindAll();
    }
}
