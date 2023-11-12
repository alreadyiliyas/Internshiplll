using Homeworks10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Homeworks10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson[] persons = new Person[]
            {
                new Teacher(1, "Person teacher fname 1", "Person teacher sname 1", new DateTime(1987, 2, 15), "Math"),
                new Teacher(2, "Person teacher fname 2", "Person teacher sname 2", new DateTime(1987, 2, 15), "History"),
                new Teacher(3, "Person teacher fname 3", "Person teacher sname 3", new DateTime(1987, 2, 15), "Physics"),
                new Teacher(4, "Person teacher fname 4", "Person teacher sname 4", new DateTime(1987, 2, 15), "Programming"),
                new Teacher(5, "Person teacher fname 5", "Person teacher sname 5", new DateTime(1987, 2, 15), "Philosophy"),
                new Teacher(6, "Person teacher fname 6", "Person teacher sname 6", new DateTime(1987, 2, 15), "Advanced Programming"),
                new Teacher(7, "Person teacher fname 7", "Person teacher sname 7", new DateTime(1987, 2, 15), "Diploma"),

                new Student(1, "Person student fname 1", "Person student sname 1", new DateTime(2003, 10, 11), new List<Subject>(), 1),
                new Student(2, "Person student fname 2", "Person student sname 3", new DateTime(2003, 10, 11), new List<Subject>(), 2),
                new Student(3, "Person student fname 3", "Person student sname 2", new DateTime(2003, 10, 11), new List<Subject>(), 3),
            };
            List<Subject> subjectsCourse1 = new List<Subject>
            {
                new Subject(1, "Math", (Teacher)persons[0]),
                new Subject(2, "History", (Teacher)persons[1]),
                new Subject(3, "Physics", (Teacher)persons[2]),
            };

            List<Subject> subjectsCourse2 = new List<Subject>
            {
                new Subject(4, "Programming", (Teacher)persons[3]),
                new Subject(5, "Philosophy", (Teacher)persons[4]),
            };

            List<Subject> subjectsCourse3 = new List<Subject>
            {
                new Subject(6, "Advanced Programming", (Teacher)persons[5]),
                new Subject(7, "Diploma", (Teacher)persons[6]),
            };
            ((Student)persons[7]).Subjects = subjectsCourse1;
            ((Student)persons[8]).Subjects = subjectsCourse2;
            ((Student)persons[9]).Subjects = subjectsCourse3;

            foreach (Person person in persons)
            {
                person.PrintPersonInfo();
                Console.WriteLine(person.ToString());
            }
            Console.WriteLine("Перевод на курс выше");

            int personCount = 0;
            int studentCount = 0;
            int teacherCount = 0;
            foreach (Person person in persons)
            {
                personCount++;

                if (person is Student)
                {
                    studentCount++;

                    Student student = person as Student;
                    if (student != null)
                    {
                        student.StudCourse++;
                    }
                }
                else if (person is Teacher)
                {
                    teacherCount++;
                }
            }

            foreach (Person person in persons)
            {
                person.PrintPersonInfo();
                Console.WriteLine(person.ToString());
            }

        }
    }
}
