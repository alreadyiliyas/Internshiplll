using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practise12
{
	internal class Program
	{
		static void Main()
		{
			//Console.WriteLine("Задание 1.");
			//Ex1();
			Console.WriteLine("Задание 2.");
			Ex2();
		}
		static void Ex1()
		{
			PropertyChanged propertyChanged = new PropertyChanged("Первое состояние");
			propertyChanged.Propertychanged += HandlePropertyChanged;
			propertyChanged.Property = "Второе состояние";
		}
		private static void HandlePropertyChanged(object sender, PropertyeventArgs e)
		{
			Console.WriteLine("Значение изменено: {0}", e.PropertyName);
		}
		static void Ex2()
		{
			double x = 3;
			double y = 4;

			MathOperation mathOperation1 = MathPlus;
			MathOperation mathOperation2 = MathMinus;
			MathOperation mathOperation3 = MathMulti;
			MathOperation mathOperation4 = MathDivision;

			PerformOperation(x, y, mathOperation1);
			PerformOperation(x, y, mathOperation2);
			PerformOperation(x, y, mathOperation3);
			PerformOperation(x, y, mathOperation4);

			MathOperation chainedOperations = mathOperation1 + mathOperation2 + mathOperation3 + mathOperation4;
			PerformOperation(x, y, chainedOperations);
		}
		public delegate double MathOperation(double x, double y);

		public static void PerformOperation(double x, double y, MathOperation mathOperation)
		{
			if (mathOperation != null)
			{
				foreach (Delegate d in mathOperation.GetInvocationList())
				{
					if (d is MathOperation operation)
					{
						double result = operation(x, y);
						Console.WriteLine($"{operation.Method.Name}: {result}");
					}
				}
			}
		}
		private static double MathPlus(double x, double y)
		{
			return x + y;
		}
		private static double MathMinus(double x, double y)
		{
			return x - y;
		}
		private static double MathMulti(double x, double y)
		{
			return x * y;
		}
		private static double MathDivision(double x, double y)
		{
			return x / y;
		}
	}
}

