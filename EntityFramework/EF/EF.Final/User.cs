using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Final
{
    //public class Company
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public List<User> Users { get; set; }
    //}
    public class UserCredential
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        // Внешний ключ
        public int UserId { get; set; }
        // Навигационное свойство
        public User User { get; set; }

    }
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string Role { get; set; }
        // Внешний ключ
        //public int CompanyId { get; set; }
        //// Навигационное свойство
        //public Company Company { get; set; }
        // Навигационное свойство
        public UserCredential UserCredential { get; set; }
    }
}
