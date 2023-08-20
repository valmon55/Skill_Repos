using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_6  
{
    class Program
    {
        static void Main(string[] args)
        {
            var numsList = new List<int[]>()
            {
                new[] {2, 3, 7, 1} ,
                new[] {45, 17, 88, 0},
                new[] {23, 32, 44, -6}
            };

            //var orderedNums = from line in numsList
            //                  from num in line
            //                  orderby num
            //                  select num;
            var orderedNums = numsList.SelectMany(s => s)
                .OrderBy(s => s);

            foreach (var s in orderedNums)
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
