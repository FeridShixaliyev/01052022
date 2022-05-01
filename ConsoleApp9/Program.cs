using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Ferid", 21, 600);
            Employee employee2 = new Employee("Sakir", 34, 1200);
            Employee employee3 = new Employee("Hesen", 27, 4322);
            Employee employee4 = new Employee("Tural", 41, 543);
            Employee employee5 = new Employee("Qasim", 41, 543);


            Department department = new Department("Code Academy",1);
            department.AddEmployee(employee1);
            department.AddEmployee(employee2);
            //department.AddEmployee(employee3);
            //department.AddEmployee(employee4);
            //department.AddEmployee(employee5);
            foreach (var item in department.employees)
            {
                Console.WriteLine(item.ShowInfo());
            }
            Console.WriteLine(department[2].ShowInfo());
        }
    }
}
