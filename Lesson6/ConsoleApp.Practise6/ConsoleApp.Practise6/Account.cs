using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public int Balance { get; set; }
        public string Password { get; set; }
        public Client Owner { get; set; }
        

        public Account(){ }

        public Account(string accountNumber, int balance, string password, Client owner)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            Password = password;
            Owner = owner;
        }

        public void PrintAccountInfo()
        {
            Console.WriteLine("Номер счета: " + AccountNumber);
            Console.WriteLine("Владелец счета: " + Owner.LastName + " " + Owner.FirstName);
        }
    }
}
