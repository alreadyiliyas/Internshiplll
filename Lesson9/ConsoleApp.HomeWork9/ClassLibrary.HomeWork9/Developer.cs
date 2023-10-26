using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.HomeWork9
{
    public class Developer : Employee
    {
        private int linesOfCodePerDay;

        public Developer(string Name, int Age, int Salary, int LinesOfCodePerDay) : base(Name, Age, Salary)
        {
            linesOfCodePerDay = LinesOfCodePerDay;
        }

        public override double CalculateAnnualSalary()
        {
            double baseSalary = base.CalculateAnnualSalary();
            double bonus = linesOfCodePerDay * 10;
            double totalSalary = baseSalary + bonus;
            Console.WriteLine("Доп. бонус за строчку кода: " + bonus);
            Console.WriteLine("Общая зарплата с бонусов: " + totalSalary);
            return totalSalary;
        }
    }
}
