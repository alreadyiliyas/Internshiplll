using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Homework1
{
    public struct Employee : IEmployee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string Gender { get; set; }
        public DateTime HireDate { get; set; }
        public override string ToString()
        {
            string DisInfo = "Имя сотрудника: " + Name + "\nДолжность сотрудника: " + Position
                            + "\nЗарплата сотрудника: " + Salary
                            + "\nДата найма сотрудника в формате дд.мм.гггг: " + HireDate
                            + "\nПол сотрудника: " + Gender;
            return DisInfo;
        }
    }
}
