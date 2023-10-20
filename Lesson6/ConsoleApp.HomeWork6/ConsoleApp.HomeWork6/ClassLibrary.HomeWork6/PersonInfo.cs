using Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary.HomeWork6
{
    public class PersonInfo
    {
        public static string GetPersonInfo(Person person)
        {
            string info = "Имя: " + person.FName + 
                          ", Фамилия: " + person.LName + 
                          ", Возраст: " + person.Age + 
                          ", Адрес: " + person.Address + 
                          ", Email: " + person.Email;

            return info;
        }
    }
}