using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        // Другие свойства

        public Person(string fName, string lName, int age, string address, string email)
        {
            FName = fName;
            LName = lName;
            Age = age;
            Address = address;
            Email = email;
        }
    }

}
