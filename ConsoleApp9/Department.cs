using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class Department
    {
        public Department(string name,int employeeLimit)
        {
            Name = name;
            EmployeeLimit = employeeLimit;
        }
        private int _empployeeLimit;
        public string Name { get; set; }
        public int EmployeeLimit
        {
            get => _empployeeLimit;
            set
            {
                if (value > 0)
                    _empployeeLimit = value;
            }
        }
        public Employee[] employees = new Employee[0];
        public Employee this[int index]
        {
            get => employees[index];
            set
            {
                employees[index] = value;
            }
        }
        public void AddEmployee(Employee employee)
        {
            if (employees.Length+1 <= EmployeeLimit)
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length - 1] = employee;
            }
            else
                throw new CapacityLimitException($"Siz isci limiti asmisiz,max-{EmployeeLimit} isci ola biler");
        }
    }

}
