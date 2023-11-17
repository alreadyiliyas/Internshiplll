using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Homework11_Exercise3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.WhatEat(EFood.Milk);
            cat.WhatEat(EFood.Fish);
            cat.WhatEat(EFood.Meet);

        }
    }
}
