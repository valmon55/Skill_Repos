using System;

namespace CS_Basic.Module_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет,\n мир!");
            const string MyName = "Jane";

            Console.WriteLine(MyName);

            Console.WriteLine("\t Привет Мир");
            Console.WriteLine("\t Мне 27 лет");
            Console.WriteLine("\t My name is \n {0}", MyName);
            Console.WriteLine("\x23");
            Console.ReadKey();
        }
    }
}
