namespace CS_Basic.Task_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 4.4.2");
            var anketa = (name: "Jane", age: 27);

            Console.WriteLine("Введите имя: "); 
            anketa.name = Console.ReadLine();
            Console.WriteLine("Укажите возраст: ");
            anketa.age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);

            Console.WriteLine("Task 4.4.3");
            var (name, age) = ("Jane", 27);

            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Укажите возраст: ");
            age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);

        }
    }
}