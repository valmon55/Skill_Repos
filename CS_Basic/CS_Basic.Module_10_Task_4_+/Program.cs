namespace CS_Basic.Module_10_Task_4__
{
    public interface IMessanger<out T>
    {
        T DeviceInfo();
    }
    public class Phone
    { }
    public class IPhone : Phone
    { }
    public class Computer
    { }
    //public class Viber: IMessanger<Phone>
    //{
    //    public Phone DeviceInfo()
    //    {
    //        return null;
    //    }
    //}
    public class Viber<T> : IMessanger<T> where T : Phone,
        new()
    {
        public T DeviceInfo()
        {
            T device = new T();
            Console.WriteLine(device);
            return new T();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IMessanger<Phone> viberInPhone = new Viber<Phone>();
            IMessanger<IPhone> viberInIPhone = new Viber<IPhone>();

            /// ковариация
            /// 
            IMessanger<Phone> viberInIPhone1 = new Viber<IPhone>();

            viberInPhone.DeviceInfo();
            viberInIPhone.DeviceInfo();

            Console.ReadKey();
        }
    }
}