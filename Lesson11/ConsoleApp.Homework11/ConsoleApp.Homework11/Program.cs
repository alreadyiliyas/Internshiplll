using ClassLibrary.Homework1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Homework11
{
    internal class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("1 - заполнить самому");
            Console.WriteLine("2 - заполнить массив автоматический");
            int choise = Convert.ToInt32(Console.ReadLine());
            if (choise == 1)
            {
                List<Employee> employees = new List<Employee>();
                Console.WriteLine("Кол-во работников: ");
                int countEmp = Convert.ToInt32(Console.ReadLine());

                if (countEmp > 0)
                {
                    for (int i = 0; i < countEmp; i++)
                    {
                        IEmployee employee = new Employee();
                        Console.WriteLine("Имя сотрудника: ");
                        employee.Name = Console.ReadLine();
                        Console.WriteLine("Позиция сотрудника: ");
                        employee.Position = Console.ReadLine();
                        Console.WriteLine("Зарплата сотрудника: ");
                        employee.Salary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите дату (в формате YYYY-MM-DD):");
                        string inputDate = Console.ReadLine();
                        if (DateTime.TryParse(inputDate, out DateTime hireDate)) { employee.HireDate = hireDate; }
                        else { Console.WriteLine("Неверный формат даты. Пожалуйста, введите дату в формате YYYY-MM-DD."); }
                        Console.WriteLine("Введите пол сотрудника: ");
                        employee.Gender = Console.ReadLine();
                        employees.Add((Employee)employee);
                    }
                    Ex1(choise, employees);
                }
                else { Console.WriteLine("Ошибка выбран не правильный параметр"); }
            }
            else if (choise == 2)
            {
                List<Employee> employees = new List<Employee>();
                //Developer
                for (int i = 0; i < 2; i++)
                {
                    IEmployee employee = new Employee();
                    employee.Name = "Developer " + (i + 1);
                    employee.Position = (EPosition.Developer).ToString();
                    employee.Salary = random.Next(100000, 200000);
                    employee.HireDate = GenerateRandomDate();
                    employee.Gender = "М";
                    employees.Add((Employee)employee);
                }
                //Manager
                for (int i = 0; i < 4; i++)
                {
                    IEmployee employee = new Employee();
                    employee.Name = "Manager " + (i + 1);
                    employee.Position = (EPosition.Manager).ToString();
                    employee.Salary = random.Next(100000, 200000);
                    employee.HireDate = GenerateRandomDate();
                    employee.Gender = "М";
                    employees.Add((Employee)employee);
                }
                //Analytics
                for (int i = 0; i < 3; i++)
                {
                    IEmployee employee = new Employee();
                    employee.Name = "Analytics " + (i + 1);
                    employee.Position = (EPosition.Analytics).ToString();
                    employee.Salary = random.Next(100000, 200000);
                    employee.HireDate = GenerateRandomDate();
                    employee.Gender = "F";
                    employees.Add((Employee)employee);
                }
                Ex1(choise, employees);
            }
            else { Console.WriteLine("Ошибка выбран не правильный параметр"); }
        }
        static DateTime GenerateRandomDate()
        {
            int year = random.Next(2000, 2023); // год от 2000 до 2022
            int month = random.Next(1, 13); // месяц от 1 до 12
            int day = random.Next(1, DateTime.DaysInMonth(year, month) + 1); // день от 1 до максимального числа дней в месяце
            return new DateTime(year, month, day);
        }
        static void Ex1(int choise, List<Employee> employees)
        {
            Console.WriteLine("вывести полную информацию обо всех сотрудниках: 3");
            Console.WriteLine("вывести полную информацию о сотрудниках, выбранной должности: 4");
            Console.WriteLine("найти в массиве всех менеджеров, зарплата которых больше средней зарплаты всех клерков, " +
                "\nвывести на экран полную информацию о таких менеджерах отсортированной по их фамилии: 5");
            Console.WriteLine("распечатать информацию обо всех сотрудниках, принятых на работу " +
                "\nпозже определенной даты (дата передается пользователем), " +
                "\nотсортированную в алфавитном порядке по фамилии сотрудника.: 6");
            Console.WriteLine("Вывести информацию о всех мужчинах, женщинах в зависимости от того что передаст пользователь. " +
                "\nПредусмотреть случай, когда, пользователь не выбирает конкретный пол, т.е. просто хочет получить информацию о всех.: 7");
            choise = Convert.ToInt32(Console.ReadLine());
            //All
            if (choise == 3)
            {
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee);
                    Console.WriteLine();
                };
            }
            //Position
            else if (choise == 4)
            {
                Console.WriteLine("Введите должность: ");
                string Pos = Console.ReadLine();
                var PosEmployees = employees.FindAll(x => x.Position == Pos);
                foreach (var PosEmployee in PosEmployees)
                {
                    Console.WriteLine(PosEmployee);
                }
            }
            //Avg
            else if (choise == 5)
            {
                string Pos = "Manager";
                var PosEmployees = employees.FindAll(x => x.Position == Pos);
                var AvgSalary = employees.Where(x => x.Position == "Manager").Average(x => x.Salary);
                Console.WriteLine("Средняя зарплата: ");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(AvgSalary);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Сотрудники у которых больше средней: ");

                var EmpAvgSalaryMore = employees.Where(x => x.Position == "Manager" && x.Salary > AvgSalary);

                foreach (var more in EmpAvgSalaryMore)
                {
                    Console.WriteLine(more);
                }
            }
            else if (choise == 6)
            {
                DateTime HiredDateEmp;
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee);
                    Console.WriteLine();
                };
                Console.WriteLine("Введите дату (в формате YYYY-MM-DD):");
                if (DateTime.TryParse(Console.ReadLine(), out HiredDateEmp))
                {
                    var HiredDateMore = employees.FindAll(x => x.HireDate > HiredDateEmp).OrderBy(x => x.Name);

                    Console.WriteLine("------------------");
                    foreach (var dateMore in HiredDateMore)
                    {
                        Console.WriteLine(dateMore);
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный формат даты!");
                }

            }
            else if (choise == 7)
            {
                Console.WriteLine("Введите пол (F-женский, M-мужской): ");
                string genderInput = Console.ReadLine();
                if (genderInput == "F")
                {
                    var genderF = employees.FindAll(x => x.Gender == genderInput);
                    foreach (var gender in genderF)
                    {
                        Console.WriteLine(gender);
                    }
                }
                else if (genderInput == "M")
                {
                    var genderF = employees.FindAll(x => x.Gender == genderInput);
                    foreach (var gender in genderF)
                    {
                        Console.WriteLine(gender);
                    }
                }
                else
                {
                    foreach (var employee in employees)
                    {
                        Console.WriteLine(employee);
                        Console.WriteLine();
                    };
                }
            }
        }
    }
}