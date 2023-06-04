using System.Xml.Linq;

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

            Console.WriteLine("Task 4.4.5");
            (string Name, string Type, double Age, int NameCount) Pet;
            
            Console.WriteLine("Введите имя питомца: ");
            Pet.Name = Console.ReadLine();
            Console.WriteLine("Введите тип питомца: ");
            Pet.Type = Console.ReadLine();
            Console.WriteLine("Укажите возраст: ");
            Pet.Age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Укажите длину имени питомца: ");
            Pet.NameCount = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Имя питомца: {0}", Pet.Name);
            Console.WriteLine("Тип питомца: {0}", Pet.Type);
            Console.WriteLine("Возраст: {0}", Pet.Age);
            Console.WriteLine("Длина имени: {0}", Pet.NameCount);
        }
    }
}