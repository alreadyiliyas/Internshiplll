using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Practise7
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Person otherPerson = (Person)obj;
            return FirstName == otherPerson.FirstName &&
                   LastName == otherPerson.LastName &&
                   Age == otherPerson.Age;
        }

        public override int GetHashCode()
        {
            return (FirstName + LastName + Age).GetHashCode();
        }

        public static bool operator ==(Person person1, Person person2)
        {
            if (ReferenceEquals(person1, person2))
            {
                return true;
            }
                
            if (ReferenceEquals(person1, null) || ReferenceEquals(person2, null))
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
