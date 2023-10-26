using ClassLibrary.HomeWork9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.HomeWork9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Ильяс", 20, 60000, 10000);
            Developer developer = new Developer("Аймурат", 21, 55000, 1000);

            Console.WriteLine("Менеджер:");
            manager.GetInfo();
            Console.WriteLine("Годовая з/п: " + manager.CalculateAnnualSalary());
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Разработчик:");
            developer.GetInfo();
            Console.WriteLine("Годовая з/п: " + developer.CalculateAnnualSalary());
        }
    }
}
