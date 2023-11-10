using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.HomeWork10Add
{
    public interface ICalculator
    {
        double Plus(double num_1, double num_2);
        double Minus(double num_1, double num_2);
        double Multiply(double num_1, double num_2);
        double Divide(double num_1, double num_2);
        double Pow(double num_1, double num_2);
    }
}
