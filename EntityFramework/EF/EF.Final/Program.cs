using System.Runtime.Intrinsics.X86;

namespace EF.Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppContext())
            {
                //var user1 = new User { Name = "Arthur", Role = "Admin" };
                //var user2 = new User { Name = "Klim", Role = "User" };
                //db.Users.Add(user1);
                //db.Users.Add(user2);
                //var user1 = new User { Name = "Alice", Role = "User" };
                //var user2 = new User { Name = "Bob", Role = "User" };
                //var user3 = new User { Name = "Bruceqq", Role = "User" };
                //db.Users.Add(user3);
                //db.Users.AddRange(user2,user3);
                //db.Users.Remove(user3);
                //var bruce = db.Users.Where(u => u.Name == "Bruce").ToList();
                //db.Users.RemoveRange(bruce);
                var firstUser = db.Users.FirstOrDefault();
                firstUser.Email = "simpleemail@gmail.com";
                db.SaveChanges();
            }
        }
    }
}