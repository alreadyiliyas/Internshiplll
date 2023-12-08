using ClassLibrary.Practise15;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practise15
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Используя рефлексию, создайте экземпляр `MyClass` без прямого вызова его конструктора (используйте `Activator.CreateInstance`).
			MyClass myClass = (MyClass)Activator.CreateInstance(typeof(MyClass));
			myClass.SName = "Test";
			myClass.FName = "Test";
			myClass.IIN = "012345678910";
			myClass.AddSub("Test");

			myClass.PrintInfo();
			Console.WriteLine("Исследование Типа:");
			Ex1(myClass);
			Console.WriteLine("Манипулирование Объектом:");
			Ex3(myClass);
			Console.WriteLine("--------------------------------------");
			Ex4(myClass);
		}
		public static void Ex1(MyClass myClass)
		{
			var type = myClass.GetType();
			Console.WriteLine("Название класса: {0}", type.Name); //Название класса
			Console.WriteLine("Список всех конструкторов (включая их модификаторы доступа).");

			var constructors = type.GetConstructors();
			Console.WriteLine("Конструкторы:");
			foreach (var constructor in constructors)
			{
				Console.WriteLine("{0} - {1}", constructor.Attributes, constructor.Name);
			}
			Console.WriteLine("Список всех полей и свойств (с указанием их типов и модификаторов доступа)");
			var props = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance); //Для получение всех свойств
			foreach (var prop in props)
			{
				Console.WriteLine(prop.Attributes + " - " + prop.Name + " - " + prop.GetValue(myClass));
			}

			Console.WriteLine("Список всех методов (с указанием их возвращаемых типов и модификаторов доступа).");
			var methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
			Console.WriteLine("Методы:");
			foreach (var method in methods)
			{
				Console.WriteLine("{0} - {1}", method.ReturnType, method.Name);
			}
		}
		public static void Ex3(MyClass myClass)
		{
			myClass.AddSub("Test 2");
			FieldInfo birthdayField = myClass.GetType().GetField("Birthday", BindingFlags.NonPublic | BindingFlags.Instance);
			if (birthdayField != null)
			{
				DateTime newBirthday = new DateTime(2023, 11, 10);
				birthdayField.SetValue(myClass, newBirthday);
			}
			// Вывод обновленной информации
			var type = myClass.GetType();
			var props = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance); //Для получение всех свойств
			foreach (var prop in props)
			{
				Console.WriteLine(prop.Attributes + " - " + prop.Name + " - " + prop.GetValue(myClass));
			}
		}
		public static void Ex4(MyClass myClass)
		{
			var type = myClass.GetType();
			var method = type.GetMethod("FullInfo", BindingFlags.NonPublic | BindingFlags.Instance);

			if (method != null)
			{
				method.Invoke(myClass, null);
			}
			else
			{
				Console.WriteLine("Метод с именем {0} не найден.", "FullInfo");
			}
		}
	}
}
