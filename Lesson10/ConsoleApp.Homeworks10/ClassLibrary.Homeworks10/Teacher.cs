using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks10
{
    public class Teacher : Person, ITeacher
    {
        public string Subject { get; set; }
        public string TeacherFName { get; set; }
        public string TeacherSName { get; set; }

        public Teacher(int id, string fName, string sName, DateTime dateOfBirthday, string subject)
            : base(id, fName, sName, dateOfBirthday)
        {
            Subject = subject;
            TeacherFName = fName;
            TeacherSName = sName;
        }
        public override bool Equals(object obj)
        {
            if (obj is Teacher otherTeacher)
            {
                return base.Equals(obj) && Subject == otherTeacher.Subject;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ Subject.GetHashCode();
        }

        public static bool operator ==(Teacher teacher1, Teacher teacher2)
        {
            if (ReferenceEquals(teacher1, teacher2))
            {
                return true;
            }

            if (teacher1 is null || teacher2 is null)
            {
                return false;
            }

            return teacher1.Equals(teacher2);
        }

        public static bool operator !=(Teacher teacher1, Teacher teacher2)
        {
            return !(teacher1 == teacher2);
        }
    }
}
