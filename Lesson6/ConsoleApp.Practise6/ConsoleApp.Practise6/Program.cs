using Bankomat;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choose;
            while (true)
            {
                Console.WriteLine("________________________________");
                Console.WriteLine("Введите число 0 для выхода: ");
                Console.WriteLine("Операции (Вставить, Удалить, Вывести): 1");
                Console.WriteLine("Войти в аккаунт: 2");
                Console.WriteLine("________________________________");
                choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 1)
                {
                    OperationWithDB.OperationWithDateBase();
                }
                else if (choose == 2)
                {
                    EnterAccounts.EnterAccount();
                }
                else if (choose == 0)
                {
                    break;
                }
            }
        }
    }
}
