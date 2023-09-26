using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_Module_1_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Фамилия:");
            String lastname = Console.ReadLine();
            Console.WriteLine("Имя:");
            String name = Console.ReadLine();
            Console.WriteLine("Отчество:");
            String surname = Console.ReadLine();
            Console.WriteLine("Приветствую тебя, " + lastname + " " + name + " " + surname);
            bool flag = true;
            int numbers = 0;
            String str = "";
            while(flag)
            {   int number = 0;
                Console.WriteLine("Введите число для суммы, введите 0 чтобы закончить");
                while(!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("!!!Введите целое число!!!");
                }
                if (number != 0)
                {
                    str += number + " + ";
                    numbers += number;
                }
                else
                {
                    flag = false;
                }
            } 
            str  = str.Remove(str.Length-3,3);
            str += " = ";
            Console.WriteLine(str + numbers);
            Console.ReadLine();
        }
    }
}
