using ClassLibrary.Homework15;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Homework15
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("1. С помощью рефлексии получить список методов класса Console и вывести на экран.");
			var type = typeof(Console);
			var methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

			//foreach (var method in methods)
   //         {
   //             Console.WriteLine("{0} - {1}", method.ReturnType, method.Name);
   //         }

			Console.WriteLine("2. Описать класс с несколькими свойствами. Создать экземпляр класса и инициализировать его свойства. С помощью рефлексии получить свойства и их значения из созданного экземпляра класса. Вывести полученные значения на экран");

			User user = new User();
			user.Name = "Iliyas";
			user.Email = "ukenov@gmail.com";
			user.Birthday = DateTime.Now;
			Console.WriteLine(user.PrintInfo()); 

			User user2 = new User(1, "Iliyas", DateTime.Now);
			Console.WriteLine(user2.PrintInfo());

			User user3 = new User(1, "Iliyas", "ukenov@gmail.com", "qwerty", DateTime.Now);
			Console.WriteLine(user3.PrintInfo());

			Console.WriteLine("3. С помощью рефлексии вызвать метод Substring класса String и извлечь из строки подстроку заданного размера");
			
			string TestText = user.PrintInfo();
			var substr = typeof(string);
			var method = substr.GetMethod("Substring", new[] { typeof(int), typeof(int) });

			object[] parameters = { 5, 31 };// Задайте размер подстроки

			// Вызов метода Substring
			object result = method.Invoke(TestText, parameters);

			Console.WriteLine(result);

			Console.WriteLine("4. Получить список конструкторов класса List<T>");
			Type listType = typeof(List<>);

			// Получаем все конструкторы типа List<T>
			ConstructorInfo[] constructors = listType.GetConstructors();

			// Выводим информацию о каждом конструкторе
			foreach (var constructor in constructors)
			{
				Console.WriteLine(constructor);
			}
		}
	}
}
