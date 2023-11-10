using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks10
{
    public class Person
    {
        public int Id { get; }
        public string FName { get; set; }
        public string SName { get; set; }
        public DateTime DateOfBirthday { get; set; }

        public Person(int id, string fName, string sName, DateTime dateOfBirthday)
        {
            Id = id;
            FName = fName;
            SName = sName;
            DateOfBirthday = dateOfBirthday;
        }
        virtual public void PrintPersonInfo()
        {
            Console.WriteLine("Информация о человеке, ID: {0}, Имя: {1}, Фамилия: {2}", Id, FName, SName);
        }
        public override string ToString()
        {
            string Info = "Информация о человеке дате рождения человека: " + DateOfBirthday;
            return Info;
        }
        public override bool Equals(object obj)
        {
            if (obj is Person otherPerson)
            {
                return Id == otherPerson.Id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public static bool operator ==(Person person1, Person person2)
        {
            if (ReferenceEquals(person1, person2))
            {
                return true;
            }

            if (person1 is null || person2 is null)
            {
                return false;
            }

            return person1.Equals(person2);
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }
    

    }
}
