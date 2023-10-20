using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.HomeWork6;
using Persons;

namespace ConsoleApp.HomeWork6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Укенов", "Ильяс", 20, "Ул. Пушкина, Дом Колотушника", "iliyasuken@gmail.com");

            string personInfo = PersonInfo.GetPersonInfo(person);
            Console.WriteLine(personInfo);
        }
    }
}
