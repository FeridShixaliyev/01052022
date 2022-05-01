using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class Employee : IPerson
    {
        public Employee(string name,int age, double salary)
        {
            Id = ++_id;
            Name = name;
            Salary = salary;
            Age = age;
        }
        private int _age;
        private int _id;
        private double _salary;
        public double Salary
        {
            get => _salary;
            set
            {
                if (value > 0)
                    _salary = value;
            }
        }
        public int Id { get; }
        public string Name { get; set; }
        public int Age
        {
            get => _age;
            set
            {
                if (value > 0)
                    _age = value;
            }
        }
       

        public string ShowInfo()
        {
            return $"\nName : {Name}\nAge : {Age}\n";
        }
    }
}
