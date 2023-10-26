using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.HomeWork9
{
    public class Manager : Employee
    {
        private int bonus;

        public Manager(string Name, int Age, int Salary, int Bonus) : base(Name, Age, Salary)
        {
            bonus = Bonus;
        }

        public override double CalculateAnnualSalary()
        {
            double baseSalary = base.CalculateAnnualSalary();
            Console.WriteLine("Бонус: " + bonus);
            double totalSalary = baseSalary + bonus;
            Console.WriteLine("Общая зарплата с бонусов: " + totalSalary);
            return totalSalary;
        }
    }
}
