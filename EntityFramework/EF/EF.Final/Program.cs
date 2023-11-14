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
                //var firstUser = db.Users.FirstOrDefault();
                //firstUser.Email = "simpleemail@gmail.com";
                //db.SaveChanges();

                //var user1 = new User { Name = "Arthur", Role = "Admin" };
                //var user2 = new User { Name = "Bob", Role = "Admin" };
                //var user3 = new User { Name = "Clark", Role = "User" };
                //var user4 = new User { Name = "Dan", Role = "User" };

                //// Добавляем user2 и сохраняем, чтобы получить Id
                //db.Users.Add(user2);
                //db.SaveChanges();

                //db.Users.AddRange(user1, user3, user4);

                //var user1Creds = new UserCredential { Login = "ArthurL", Password = "qwerty123" };
                //var user2Creds = new UserCredential { Login = "BobJ", Password = "asdfgh585" };
                //var user3Creds = new UserCredential { Login = "ClarkK", Password = "111zlt777" };
                //var user4Creds = new UserCredential { Login = "DanE", Password = "zxc333vbn" };

                //user1Creds.User = user1;
                //user2Creds.UserId = user2.Id;
                //user3.UserCredential = user3Creds;
                //user4.UserCredential = user4Creds;

                //// Не добавляем user1Creds в БД
                //db.UserCredentials.AddRange(user2Creds, user3Creds, user4Creds);

                //db.SaveChanges();
            }
        }
    }
}