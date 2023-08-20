using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_4
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

            var courses = new List<Course>()
            {
                new Course("C# Language", new DateTime(2021,9,1)),
                new Course("PL/SQL Language", new DateTime(2020,9,1))
            };

            var studentsCS = from student in students
                             where student.Age < 29
                             from language in student.Languages
                             where language == "английский"
                             from course in courses
                             where course.Name.Contains("C#")
                             let birthYear = DateTime.Now.Year - student.Age
                             select new
                             {
                                 Name = student.Name,
                                 BirthYear = birthYear,
                                 Course = course.Name
                             };

            foreach (var s in studentsCS)
                Console.WriteLine("Студент " + s.Name + " Дата рождения: " + s.BirthYear.ToString() + " Курс: " + s.Course);

            Console.ReadKey();
        }
    }
}
