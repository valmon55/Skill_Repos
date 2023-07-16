namespace CS_Basic.Module_10_Task_4_4
{
    public class User
    { }
    public class Account : User
    { }
    public interface IUpdater<in T>
    {
        void Update(T entity);
    }
    public class UserService<T> : IUpdater<T> where T : User,
        new()
    {
        public void Update(T entity)
        {
            Console.WriteLine(entity);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IUpdater<User> UserUpd = new UserService<User>();
            UserUpd.Update(new User());

            IUpdater<Account> AccUpd = new UserService<Account>();
            AccUpd.Update(new Account());

            IUpdater<Account> AccUpd_Contravar = new UserService<User>();

        }
    }
}