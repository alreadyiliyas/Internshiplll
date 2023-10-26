using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. В С # индексация начинается с нуля, но в некоторых языках программирования это не так. Например, в Turbo Pascal индексация массиве начинается с 1. Напишите класс RangeOfArray, который позволяет работать с массивом такого типа, в котором индексный диапазон устанавливается пользователем. Например, в диапазоне от 6 до 10, или от –9 до 15.");
            Ex1();
            Console.WriteLine("Задание 2. В файле хранится информация об объеме продаж товара за пять последних месяцев. С помощью метода наименьших квадратов спрогнозировать объемы продаж на следующие три месяца. В качестве линии тренда выбрать линейную функцию.");
            Ex2();
        }
        public static void Ex1()
        {
            Console.WriteLine("Начало индекса: ");
            int StartIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Конец индекса: ");
            int EndIndex = Convert.ToInt32(Console.ReadLine());
            Exercise1 exercise = new Exercise1(StartIndex, EndIndex); // Создание экземпляра с начальным индексом и конечным индексом

            Random rnd = new Random();
            for (int i = StartIndex; i <= EndIndex; i++)
            {
                exercise[i] = rnd.Next(0, 101);
            }

            for (int i = StartIndex; i <= EndIndex; i++)
            {
                Console.Write(exercise[i] + " ");
            }
        }
        public static void Ex2()
        {
            double[] sales = { 100, 120, 130, 140, 150 };

            double a, b;
            CalculateLinearRegression(sales, out a, out b);

            // Прогнозируем объемы продаж на следующие три месяца
            double[] forecastedSales = new double[3];
            for (int i = 0; i < 3; i++)
            {
                int month = 6 + i; // номер месяца (6, 7, 8)
                forecastedSales[i] = PredictSales(a, b, month);
            }

            Console.WriteLine("Прогноз объемов продаж на следующие три месяца:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Месяц {i + 6}: {forecastedSales[i]}");
            }
        }
        static void CalculateLinearRegression(double[] data, out double a, out double b)
        {
            int n = data.Length;
            double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;

            for (int i = 0; i < n; i++)
            {
                double x = i + 1; // Месяцы пронумерованы с 1 до 5
                double y = data[i];
                sumX += x;
                sumY += y;
                sumXY += x * y;
                sumX2 += x * x;
            }

            a = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
            b = (sumY - a * sumX) / n;
        }

        static double PredictSales(double a, double b, int month)
        {
            return a * month + b;
        }
    }
    public class Exercise1
    {
        private int[] arr;

        public Exercise1(int startIndex, int endIndex)
        {
            this.arr = new int[endIndex - startIndex + 1];
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
        }

        public int StartIndex { get; set; }
        public int EndIndex { get; set; }

        public int this[int index]
        {
            get
            {
                if (index < StartIndex || index > EndIndex)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
                return arr[index - StartIndex];
            }
            set
            {
                if (index < StartIndex || index > EndIndex)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
                arr[index - StartIndex] = value;
            }
        }
    }

}
