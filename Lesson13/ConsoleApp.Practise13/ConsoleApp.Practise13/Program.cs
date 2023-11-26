using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practise13
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Задание 1. Создать коллекцию List <int>. Вывести на экран позицию и значение элемента, являющегося вторым максимальным значением в коллекции");
			Ex1();
			Console.WriteLine("Задание 2. Дана коллекция типа List<double>. Вывести на экран элементы списка, значение которых больше среднего арифметического всех элементов коллекции.");
			Ex2();
			Console.WriteLine("Задание 3. Дан файл, в котором записан набор чисел. Переписать в другой файл все числа в обратном порядке.");
			Ex3();
			Console.WriteLine("Задание 4. Дан файл, содержащий информацию о сотрудниках фирмы: фамилия, имя, отчество, пол, возраст, размер зарплаты. За один просмотр файла напечатать элементы файла в следующем порядке: сначала все данные о сотрудниках, зарплата которых меньше 10000, потом данные об остальных сотрудниках, сохраняя исходный порядок в каждой группе сотрудников.");
			Console.WriteLine("Задание 5.");

		}
		static void Ex1()
		{
			List<int> list1 = new List<int>();
			Random random = new Random();
			for (int i = 0; i < 10; i++)
			{
				list1.Add(random.Next(-100, 100));
			}

			int max = list1.Max();
			int secondMax = list1.Where(x => x < max).Max();

			Console.WriteLine("Макс значение: " + max);
			Console.WriteLine("Второе макс значение: " + secondMax);

			foreach (var num in list1)
			{
				Console.Write(num + " ");
			}
			Console.WriteLine();

			list1.RemoveAll(x => (x % 2 != 0));
			foreach (var num in list1)
			{
				Console.Write(num + " ");
			}
			Console.WriteLine();
		}
		static void Ex2()
		{
			List<double> list2 = new List<double>();
			Random random = new Random();
			for (int i = 0; i < 10; i++)
			{
				list2.Add(random.Next(-100, 100));
			}

			foreach (var num in list2)
			{
				Console.Write(num + " ");
			}
			Console.WriteLine();

			double avg = list2.Average();
			Console.WriteLine("avg: " + avg);

			list2.RemoveAll(x => x < avg);
			foreach (var num in list2)
			{
				Console.Write(num + " ");
			}
			Console.WriteLine();
		}
		static void Ex3()
		{
			string inputFilePath = "C:\\Users\\User\\source\\repos\\CsharpLesson\\Lesson13\\ConsoleApp.Practise13\\FirstArray.txt"; 
			string outputFilePath = "C:\\Users\\User\\source\\repos\\CsharpLesson\\Lesson13\\ConsoleApp.Practise13\\SecondArray.txt";
			List<int> numbers = ReadNumbersFromFile(inputFilePath);

			List<int> reversedNumbers = new List<int>(numbers);
			reversedNumbers.Reverse();
			WriteNumbersToFile(reversedNumbers, outputFilePath);

			Console.WriteLine("Программа завершена. Проверьте файл output.txt.");
		}
		static List<int> ReadNumbersFromFile(string filePath)
		{
			List<int> numbers = new List<int>();

			try
			{
				// Чтение строк из файла и преобразование их в числа
				string[] lines = File.ReadAllLines(filePath);
				foreach (string line in lines)
				{
					if (int.TryParse(line, out int number))
					{
						numbers.Add(number);
					}
					else
					{
						Console.WriteLine($"Ошибка: Невозможно преобразовать строку в число: {line}");
					}
				}
			}
			catch (IOException ex)
			{
				Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
			}

			return numbers;
		}

		static void WriteNumbersToFile(IEnumerable<int> numbers, string filePath)
		{
			try
			{
				// Запись чисел в обратном порядке в файл
				File.WriteAllLines(filePath, numbers.Select(num => num.ToString()));
			}
			catch (IOException ex)
			{
				Console.WriteLine($"Ошибка при записи файла: {ex.Message}");
			}
		}
	}
}
