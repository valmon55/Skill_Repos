using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };

            //var pets = from pet in words
            //           orderby pet.Length
            //           select new
            //           {
            //               Pet = pet,
            //               NameLength = pet.Length
            //           };
            var pets = words.Select(
                w => new
                {
                    Pet = w,
                    NameLength = w.Length
                }
                ).OrderBy(w => w.NameLength);

            foreach (var pet in pets)
                Console.WriteLine(pet.Pet + " - " + pet.NameLength);

            Console.ReadKey();
        }
    }
}
