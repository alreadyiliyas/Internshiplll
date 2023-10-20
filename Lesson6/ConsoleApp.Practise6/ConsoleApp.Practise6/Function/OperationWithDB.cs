using Bankomat;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class OperationWithDB
{
    public static void OperationWithDateBase()
    {
        using (var db = new LiteDatabase("BankData.db"))
        {
            var clients = db.GetCollection<Client>("clients");
            var accounts = db.GetCollection<Account>("accounts");
            var banks = db.GetCollection<Banc>("banks");



            Console.WriteLine("1 to Insrt");
            Console.WriteLine("2 to select all");
            Console.WriteLine("3 to delete all");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                Console.WriteLine("Вставить свои данные: 1");
                Console.WriteLine("Вставить сущ. данные: 2");

                int innerChoise = Convert.ToInt32(Console.ReadLine());
                if (innerChoise == 1)
                {
                    Console.WriteLine("Напишите Фамилию: ");
                    string LName = Console.ReadLine();

                    Console.WriteLine("Напишите Имя: ");
                    string FName = Console.ReadLine();

                    Console.WriteLine("Напишите Дату рождения (дд/мм/гггг): ");
                    string inputDateOfBirth = Console.ReadLine();

                    if (DateTime.TryParseExact(inputDateOfBirth, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime DateOfBirth))
                    {
                        Console.WriteLine("Корректно");
                    }
                    else
                    {
                        // В случае некорректного ввода
                        Console.WriteLine("Некорректный формат даты рождения. Используйте дд/мм/гггг.");
                    }

                    Console.WriteLine("Напишите ИИН: ");
                    string IIN = Console.ReadLine();

                    var client = new Client(LName, FName, DateOfBirth, IIN);
                    clients.Insert(client);

                    Random random = new Random();
                    string accountNumber = "KZ" + random.Next(100000000, 999999999).ToString();


                    Console.WriteLine("Напишите пароль для аккаунта: ");
                    string Password = Console.ReadLine();

                    var account = new Account(accountNumber, 0, Password, client);
                    accounts.Insert(account);

                    var banс = new Banc("Банк Сентр Кредит", "Ул. Аль-Фараби 38");
                    banс.AddAccount(account);

                    banks.Insert(banс);

                }
                else if (choose == 2)
                {
                    var client = new Client("Укенов", "Ильяс", new DateTime(2003, 10, 11), "031011______");
                    clients.Insert(client);

                    var account = new Account("KZ11111111111", 1000, "qwerty", client);
                    accounts.Insert(account);

                    var banс = new Banc("Банк Сентр Кредит", "Ул. Аль-Фараби 38");
                    banс.AddAccount(account);

                    banks.Insert(banс);
                }
                else
                {
                    Console.WriteLine("Ошибка!");
                }
            }


            if (choose == 2)
            {
                var allClients = clients.FindAll();
                var allAccounts = accounts.FindAll();
                var allBanks = banks.FindAll();
                if (clients.Count() > 0 && accounts.Count() > 0 && banks.Count() > 0)
                {
                    foreach (var cli in allClients)
                    {
                        Console.WriteLine("Имя клиента: " + cli.FirstName + " " + cli.LastName);
                    }

                    foreach (var acc in allAccounts)
                    {
                        Console.WriteLine("Номер счета: " + acc.AccountNumber + ", Баланс: " + acc.Balance);
                    }

                    foreach (var bank in allBanks)
                    {
                        Console.WriteLine("Название банка: " + " " + bank.Name + ", Адрес: " + " " + bank.Address);
                    }
                }
                else
                {
                    Console.WriteLine("База данных пуста.");
                }

            }

            if (choose == 3)
            {
                clients.DeleteAll();
                accounts.DeleteAll();
                banks.DeleteAll();
            }
        }
    }
}
