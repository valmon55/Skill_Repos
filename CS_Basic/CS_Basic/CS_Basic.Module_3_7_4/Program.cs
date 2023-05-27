using System;

namespace CS_Basic.Module_3_7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Enter your age: ");
            //var age = checked((byte)int.Parse(Console.ReadLine()));
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);

            Console.Write("Enter your birthdate: ");
            var birthday = Console.ReadLine();
            Console.WriteLine($"Your birthdate is {birthday}");
            //Console.Write("What is your favorite day of week? ");
            //var week_day = (DayOfWeek) int.Parse(Console.ReadLine());
            //Console.Write("Your favorite day is {0}", week_day );

            Console.ReadKey();
        }
        enum DayOfWeek 
        { 
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
