using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.HomeWork10Add
{
    public class SimpleCalculator : ICalculator
    {
        public double Plus(double num_1, double num_2)
        {
            return num_1 + num_2;
        }
        public double Multiply(double num_1, double num_2)
        {
            return num_1 * num_2;
        }
        public double Minus(double num_1, double num_2)
        {
            return num_1 - num_2;
        }
        public double Divide(double num_1, double num_2)
        {
            if (num_1 == 0 || num_2 == 0) 
            {
                throw new ArgumentException("Встретился ноль");
            }
            return num_1 / num_2;
        }
        public double Pow(double num_1, double num_2)
        {
            throw new ArgumentException("Необходимо использовать продвинутый калькулятор");
        }
    }
}
