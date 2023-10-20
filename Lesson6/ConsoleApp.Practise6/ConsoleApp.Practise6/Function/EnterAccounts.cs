using Bankomat;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class EnterAccounts
{
    public static void EnterAccount()
    {
        using (var db = new LiteDatabase("BankData.db"))
        {
            var clients = db.GetCollection<Client>("clients");
            var accounts = db.GetCollection<Account>("accounts");

            Console.Write("Введите Имя: ");
            string LastName = Console.ReadLine();

            Console.Write("Введите Фамилию: ");
            string FirstName = Console.ReadLine();

            // Найдем клиента по имени и фамилии
            var client = clients.FindOne(x => x.FirstName == FirstName && x.LastName == LastName);

            if (client != null)
            {
                // Найден клиент, теперь найдем его счет
                var account = accounts.FindOne(x => x.Owner.Id == client.Id);

                if (account != null)
                {
                    // Найден счет клиента
                    Console.WriteLine("Найден счет клиента:");
                    Console.WriteLine($"Номер счета: {account.AccountNumber}");

                    int Attempts = 3;
                    bool success = false;

                    for (int i = 0; i < Attempts; i++)
                    {
                        Console.Write("Введите пароль: ");
                        string inputPassword = Console.ReadLine();

                        if (inputPassword == account.Password)
                        {
                            Console.WriteLine("Успешно");
                            success = true;
                            break; // Выходим из цикла, так как пароль верный
                        }
                        else
                        {
                            Console.WriteLine("Неверный пароль. Попыток осталось: " + (Attempts - i - 1));
                        }
                    }

                    if (!success)
                    {
                        Console.WriteLine("Исчерпаны все попытки ввода пароля. Ошибка.");
                    }
                    else
                    {
                        // Вход выполнен успешно, открываем меню
                        while (true)
                        {
                            Console.WriteLine("Меню:");
                            Console.WriteLine("a. Вывод баланса на экран");
                            Console.WriteLine("b. Пополнение счета");
                            Console.WriteLine("c. Снять деньги со счета");
                            Console.WriteLine("d. Выход");

                            Console.Write("Выберите действие (a/b/c/d): ");
                            char choice = Console.ReadKey().KeyChar;
                            Console.WriteLine();

                            switch (choice)
                            {
                                case 'a':
                                    // Вывод баланса
                                    Console.WriteLine("Баланс счета: " + account.Balance);
                                    break;
                                case 'b':
                                    // Пополнение счета
                                    Console.Write("Введите сумму для пополнения: ");
                                    int depositAmount = int.Parse(Console.ReadLine());
                                    account.Balance += depositAmount;
                                    Console.WriteLine("Счет успешно пополнен. Новый баланс: " + account.Balance);
                                    break;
                                case 'c':
                                    // Снятие денег
                                    Console.Write("Введите сумму для снятия: ");
                                    int withdrawalAmount = int.Parse(Console.ReadLine());
                                    if (withdrawalAmount <= account.Balance)
                                    {
                                        account.Balance -= withdrawalAmount;
                                        Console.WriteLine("Деньги успешно сняты. Новый баланс: " + account.Balance);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Недостаточно средств на счете.");
                                    }
                                    break;
                                case 'd':
                                    // Выход
                                    return; // Завершаем программу
                                default:
                                    Console.WriteLine("Некорректный выбор. Пожалуйста, выберите a, b, c или d.");
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Счет для данного клиента не найден.");
                }
            }
            else
            {
                Console.WriteLine("Клиент с указанными именем и фамилией не найден.");
            }
        }
    }
}
