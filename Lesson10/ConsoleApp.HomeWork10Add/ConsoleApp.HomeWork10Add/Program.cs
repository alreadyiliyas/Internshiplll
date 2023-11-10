using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.HomeWork10Add;

namespace ConsoleApp.HomeWork10Add
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICalculator simpleCalc = new SimpleCalculator();
            ICalculator advancedCalc = new AdvancedCalculator();
            IStorable saveState = new AdvancedCalculator();
            string path = "C:/Users/User/source/repos/CsharpLesson/Lesson10/ConsoleApp.HomeWork10Add/State.txt";
        
            try
            {
                Console.WriteLine(simpleCalc.Plus(1, 2));
                Console.WriteLine(simpleCalc.Minus(1, 2));
                Console.WriteLine(simpleCalc.Multiply(1, 2));
                Console.WriteLine(simpleCalc.Divide(1, 1));
                double powResult = advancedCalc.Pow(5, 5);
                saveState.SaveState(path);
                Console.WriteLine(powResult);
                saveState.LoadState(path);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message); ;
            }
            
        }
    }
}
