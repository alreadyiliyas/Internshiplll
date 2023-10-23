using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.HomeWork7;

namespace ConsoleApp.HomeWork7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tank> tanks = new List<Tank>();

            // Создание и добавление 5 танков Т-34
            for (int i = 0; i < 5; i++)
            {
                Tank t34 = new Tank("Т-34");
                tanks.Add(t34);
            }

            // Создание и добавление 5 танков Panther
            for (int i = 0; i < 5; i++)
            {
                Tank panther = new Tank("Panther");
                tanks.Add(panther);
            }

            // Вывод информации о танках в списке
            foreach (Tank tank in tanks)
            {
                Console.WriteLine("____________________________________________________");
                Console.WriteLine(tank.GetTankParameters());
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 5; j < 10; j++)
                {
                    int result = tanks[i].GetLevelAmmunition() ^ tanks[j].GetLevelAmmunition();
                    if (result > 0)
                    {
                        Console.WriteLine($"{tanks[i].GetTankName()} (ID {tanks[i].GetTankId()}) победил {tanks[j].GetTankName()} (ID {tanks[j].GetTankId()})!");
                    }
                       
                    else if (result < 0)
                    {
                        Console.WriteLine($"{tanks[j].GetTankName()} (ID {tanks[j].GetTankId()}) победил {tanks[i].GetTankName()} (ID {tanks[i].GetTankId()})!");
                    } 
                }
            }
        }
    }     
}
