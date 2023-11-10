using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.HomeWork10Add
{
    public class AdvancedCalculator : ICalculator, IStorable
    {
        double sum = 0;
        char operation;
        public double Plus(double num_1, double num_2)
        {
            sum = num_1 + num_2;
            operation = '+';
            return sum;
        }
        public double Multiply(double num_1, double num_2)
        {
            sum = num_1 * num_2;
            operation = '*';
            return sum;
        }
        public double Minus(double num_1, double num_2)
        {
            sum = num_1 - num_2;
            operation = '-';
            return sum;
        }
        public double Divide(double num_1, double num_2)
        {
            if (num_1 == 0 || num_2 == 0)
            {
                throw new ArgumentException("Встретился ноль");
            }
            sum = num_1 / num_2;
            operation = '/';
            return sum;
        }
        public double Pow(double num_1, double num_2)
        {
            operation = '^';
            if (num_2 == 0)
            {
                sum = 1;
                return 1;
            }
            else if (num_2 < 0)
            {
                sum = -(num_2 / num_1);
            }
            else
            {
                sum = 1;
                for (int i = 1; i <= num_2; i++)
                {
                    sum *= num_1;
                }
            }
            return sum;

        }
        public void SaveState(string path)
        {
            try
            {
                string content = $"Операция: {operation}, итог: {sum}, время: {DateTime.Now}";
                File.AppendAllText(path, content, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving state: {ex.Message}");
            }
        }
        public void LoadState(string path)
        {
            string content = File.ReadAllText(path);
            Console.WriteLine($"Loaded state: {content}");
        }
    }
}
