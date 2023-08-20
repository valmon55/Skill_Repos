using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = { "раз два три",
                              "четыре пять шесть",
                              "семь восемь девять"
                            };
            var n = from line in text
                    from word in line.Split(' ')
                    select word;

            foreach (var s in n)
                Console.WriteLine(s);

            Console.ReadKey();
                         
        }
    }
}
