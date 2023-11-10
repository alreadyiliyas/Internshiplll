using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homeworks10
{
    public class Student : Person, IStudent
    {
        public List<Subject> Subjects { get; set; }
        public int StudCourse { get; set; }

        public Student(int id, string fName, string sName, DateTime dateOfBirthday, List<Subject> subjects, int studCourse)
            : base(id, fName, sName, dateOfBirthday)
        {
            Subjects = subjects;
            StudCourse = studCourse;
        }

        public override void PrintPersonInfo()
        {
            base.PrintPersonInfo();
            Console.WriteLine("Курс студента: {0}", StudCourse);
            Console.WriteLine("Предметы:");
            foreach (Subject subject in Subjects)
            {
                Console.WriteLine("Предмет: {0}, Преподаватель: {1}", subject.SubjectName, subject.Teacher.FName);
            }
        }
        public override bool Equals(object obj)
        {
            if (obj is Student otherStudent)
            {
                return base.Equals(obj) && StudCourse == otherStudent.StudCourse;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ StudCourse.GetHashCode();
        }

        public static bool operator ==(Student student1, Student student2)
        {
            if (ReferenceEquals(student1, student2))
            {
                return true;
            }

            if (student1 is null || student2 is null)
            {
                return false;
            }

            return student1.Equals(student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(student1 == student2);
        }
    }
}
