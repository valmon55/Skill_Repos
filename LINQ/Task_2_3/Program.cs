using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
               new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
               new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
               new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
               new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };

            var ankets = from student in students
                         let birthYear = System.DateTime.Now.Year - student.Age
                         where student.Age < 27
                         select new Application()
                         {
                             Name = student.Name,
                             YearOfBirth = birthYear
                         };
            foreach (var anket in ankets)
                Console.WriteLine(anket.Name + ": " + anket.YearOfBirth.ToString());

            Console.ReadKey();
        }
    }
}
