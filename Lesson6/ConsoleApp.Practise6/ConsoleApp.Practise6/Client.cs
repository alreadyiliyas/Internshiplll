using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IIN { get; set; }

        public Client() { } 

        public Client(string firstName, string lastName, DateTime dateOfBirth, string iin)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            IIN = iin;
        }

        public void PrintClientInfo()
        {
            Console.WriteLine("Информация о инициалах клиента: {0} {1}", FirstName, LastName);
            Console.WriteLine("Информация о дате рождения клиента: {0}", DateOfBirth);
            Console.WriteLine("Информация о ИИНе клиента: {0}", IIN);
        }

    }
}
