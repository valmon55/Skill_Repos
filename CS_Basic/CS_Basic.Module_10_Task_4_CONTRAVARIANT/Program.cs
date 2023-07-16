namespace CS_Basic.Module_10_Task_4_CONTRAVARIANT
{
    public interface IMessanger<in T>
    {
        void GetDeviceInfo(T device);
    }
    public class Phone
    { }
    public class IPhone : Phone
    { }
    public class Computer
    { }
    public class Viber<T> : IMessanger<T> where T : Phone,
    new()
    {
        public void GetDeviceInfo(T device)
        {
            //T device = new T();
            Console.WriteLine(device);
            //return new T();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMessanger<Phone> viberInPhone = new Viber<Phone>();
            viberInPhone.GetDeviceInfo(new Phone());

            IMessanger<IPhone> viberInIPhone = new Viber<IPhone>();
            viberInIPhone.GetDeviceInfo(new IPhone());

            IMessanger<IPhone> viberInIPhone1 = new Viber<Phone>();
            viberInIPhone1.GetDeviceInfo(new IPhone());

            Console.ReadKey();
        }
    }
}