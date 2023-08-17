using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<char> uniqueChars = new HashSet<char>();
            string s;
            char[] digits = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char[] delim = new char[] { ' ', '.', ','};
            bool hasNumbes;

            do
            {
                Console.WriteLine("Введите строку:");
                s = Console.ReadLine();

                char[] chars = s.ToCharArray();
                foreach (char c in chars)
                    uniqueChars.Add(c);

                Console.WriteLine($"всего знаков {uniqueChars.Count}");
                hasNumbes = uniqueChars.Overlaps(digits);

                Console.WriteLine($"HAS DIGITS {hasNumbes}");

                uniqueChars.ExceptWith(delim);
                Console.WriteLine($"без знаков препинания {uniqueChars.Count}");

                //string s = "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";
                //for (int i = 0; i < s.Length; i++)
                //{
                //    uniqueChars.Add(s.ElementAt<char>(i));
                //}
                //Console.WriteLine(uniqueChars.Count);
                //Console.ReadKey();
                uniqueChars.Clear();
            }
            while (1 == 1);
        }
    }
}
