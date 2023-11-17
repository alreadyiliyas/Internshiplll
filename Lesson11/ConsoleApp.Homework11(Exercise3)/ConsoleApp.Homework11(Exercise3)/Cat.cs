using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Homework11_Exercise3_
{
    public class Cat
    {
        public string Name { get; set; }
        private int LevelSatiety;

        public Cat()
        {
            LevelSatiety = 0;
        }

        public void WhatEat(EFood food)
        {
            if (LevelSatiety == 0)
            {
                Console.WriteLine("Кот {0} голодный", Name);
            }

            if (food == EFood.Fish)
            {
                LevelSatiety += 30;
            }
            else if (food == EFood.Meet)
            {
                LevelSatiety += 35;
            }
            else if (food == EFood.Milk)
            {
                LevelSatiety += 10;
            }
            else
            {
                Console.WriteLine("Неизвестный вид еды");
                return;
            }

            Console.WriteLine("Имя кота (кошки): {0}, Уровень сытости: {1}", Name, LevelSatiety);
        }
    }
}
