namespace LINQ.Task_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var departments = new List<Department>()
            {
               new Department() {Id = 1, Name = "Программирование"},
               new Department() {Id = 2, Name = "Продажи"}
            };
            var employees = new List<Employee>()
            {
               new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
               new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
               new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
               new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
            };
            //15.4.2
            var empByDeptGroup = departments.GroupJoin(employees, d => d.Id, e => e.DepartmentId,
                                                        (d, t) => new
                                                        {
                                                            DepName = d.Name,
                                                            EmpName = t.Select(s => s.Name)
                                                        });
            foreach (var dep in empByDeptGroup)
            {
                Console.WriteLine($"{dep.DepName}:");
                foreach (string emp in dep.EmpName)
                    Console.WriteLine(emp);

            }
            Console.ReadKey();
            //15.4.1
            var empByDept = from employee in employees
                            join deptartment in departments on employee.DepartmentId equals deptartment.Id
                            select new
                            {
                                DepName = deptartment.Name,
                                Employee = employee.Name
                            };
            foreach (var emp in empByDept)
                Console.WriteLine($"{emp.DepName} {emp.Employee}");

            Console.ReadKey();
        }
    }
}