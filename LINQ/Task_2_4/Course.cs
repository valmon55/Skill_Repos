using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_4
{
    class Course
    {
        public string Name;
        public DateTime StartDate;
        public Course(string name, DateTime startDate)
        {
            Name = name;
            StartDate = startDate;
        }
    }
}
