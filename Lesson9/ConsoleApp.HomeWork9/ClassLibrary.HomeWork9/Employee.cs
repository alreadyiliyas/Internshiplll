using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.HomeWork9
{
    public class Employee
    {
        private string name;
        private int age;
        protected int salary;

        public Employee(string Name, int Age, int Salary)
        {
            name = Name;
            age = Age;
            salary = Salary;
        }

        public void GetInfo()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("Зарплата: " + salary);
        }

        public virtual double CalculateAnnualSalary()
        {
            return salary * 12;
        }
    }
}
