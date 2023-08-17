using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        public static Stack<string> words = new Stack<string>();
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
            Console.WriteLine();
            

            while (true)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "pop":
                        if(words.Count > 0)
                            words.Pop();
                        break;
                    case "peek":
                        if (words.Count > 0)
                            words.Peek();
                        break;
                    default:
                        words.Push(input); // Изменить здесь
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("В стеке:");

                foreach (var word in words)
                {
                    Console.WriteLine(" " + word);
                }
            }
        }
    }
}
