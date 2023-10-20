using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Banc
    {
        public int idBank;
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Account> Accounts { get; } = new List<Account>();

        // Другие поля и свойства, если необходимо
        public Banc() { }
        public Banc(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public void PrintBankInfo()
        {
            Console.WriteLine("Название банка: " + Name);
            Console.WriteLine("Улица банка: " + Address);
            Console.WriteLine("----------------Счета в банке--------------");
            foreach (var account in Accounts)
            {
                Console.WriteLine("Владелец счета: " + account.Owner.LastName + " " + account.Owner.FirstName);
                Console.WriteLine("Счет клиента: " + account.AccountNumber);
            }
            
        }
        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }
    }
}
