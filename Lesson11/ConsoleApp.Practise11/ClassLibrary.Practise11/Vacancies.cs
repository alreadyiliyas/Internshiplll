using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Practise11
{
    public class Vacancies
    {
        public string NameVacancy { get; set; } 
        public string DescriptionVacancy {get; set; }
        public int VacancySalary {get; set; }
        public Vacancies()
        {

        }
        public Vacancies(string nameVacancy, string descriptionVacancy, int vacancySalary)
        {
            NameVacancy = nameVacancy;
            DescriptionVacancy = descriptionVacancy;
            VacancySalary = vacancySalary;
        }

    }
}
