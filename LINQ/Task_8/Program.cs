using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var objects = new List<object>()
            {
                1,
                "Сергей",
                "Андрей",
                300
            };
            foreach (object s in objects)
                Console.WriteLine(s.GetType());

            //var names = from p in objects
            //                //where p.GetType().ToString() == "System.String" // можно так
            //            where p is string
            //            orderby p
            //            select p;
            var names = objects.Where(p => p is string).OrderBy(p => p);

            foreach (string s in names)
                Console.WriteLine(s);

            Console.ReadKey();

        }
    }
}
