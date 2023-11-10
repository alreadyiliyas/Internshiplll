using Homeworks10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks10
{
    public class Subject
    {
        public int IdSubject { get; set; }
        public string SubjectName { get; set; }
        public Teacher Teacher { get; set; }

        public Subject(int idSubject, string subjectName, Teacher teacher)
        {
            IdSubject = idSubject;
            SubjectName = subjectName;
            Teacher = teacher;
        }
    }
}
