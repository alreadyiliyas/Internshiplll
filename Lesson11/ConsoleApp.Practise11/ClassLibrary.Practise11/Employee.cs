using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Practise11
{
    public struct Employee 
    {
        public string EmployeeName;
        public Vacancies Vacancy;
        public DateTime EmploymentDate;
        public int Salary;
        public void PrintInfo()
        {
            Console.WriteLine("Имя работника: {0}", EmployeeName);
            Console.WriteLine("Название вакансии: {0}, Описание вакансии {1}, З/п вакансии {2}", Vacancy.NameVacancy, Vacancy.DescriptionVacancy, Vacancy.VacancySalary);
            Console.WriteLine("Дата трудоустройства: {0}", EmploymentDate);
            Console.WriteLine("Зарплата: {0}", Vacancy.VacancySalary);
        }
    };

}
