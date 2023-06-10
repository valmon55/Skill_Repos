using System;
using System.Drawing;

namespace CS_Basic.Module_5_Task_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, int age) anketa;

            Console.Write("Введите имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);

            string?[] favcolor = new string[3];
            for (int i = 0; i < favcolor.Length; i++)
            {
                Console.WriteLine("Введите ваш цвет #" + i.ToString() + " ");
                favcolor[i] = ShowColor(anketa.name);
            }

            for (int i = 0; i < favcolor.Length; i++)
            {
                Console.WriteLine("Ваш цвет #" + i.ToString() + " " + favcolor[i]);
            }

            Console.ReadKey();
        }
        static string? ShowColor(string name)
        {
            Console.Write("{0} введите ваш цвет ", name);
            return Console.ReadLine();
        }
    }
}