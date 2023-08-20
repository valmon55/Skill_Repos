using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = {"Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };

            //List<string> list = new List<string>();
            //foreach(string person in people)
            //{
            //    if (person.ToUpper().StartsWith("А"))
            //        list.Add(person);
            //}
            //list.Sort();

            /// LINQ
            //var list = from p in people
            //           where p.ToUpper().StartsWith("А")
            //           orderby p
            //           select p;

            /// Extentions
            var list = people.Where(p => p.ToUpper().StartsWith("А")).OrderBy(p => p);

            foreach(string s in list)
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
