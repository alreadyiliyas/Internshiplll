using Homeworks10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homeworks10
{
    public class StudentWithAdvisor : Student, IAdvisor
    {
        public Teacher Advisor { get; set; }

        public StudentWithAdvisor(int id, string fName, string sName, DateTime dateOfBirthday, List<Subject> subjects, int studCourse, Teacher advisor)
            : base(id, fName, sName, dateOfBirthday, subjects, studCourse)
        {
            Advisor = advisor;
        }
    }
}
