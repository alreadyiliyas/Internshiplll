using ClassLibrary.Practise11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace ConsoleApp.Practise11
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Ex1();
        }
        public static void Ex1()
        {
            Employee employee = new Employee();
            employee.EmployeeName = "Iliyas";
            employee.Vacancy = new Vacancies("Developer", "Backend developer", 10000);
            employee.EmploymentDate = DateTime.Now;
            employee.Salary = 10000;

            employee.PrintInfo();
        }
        
    }
}
