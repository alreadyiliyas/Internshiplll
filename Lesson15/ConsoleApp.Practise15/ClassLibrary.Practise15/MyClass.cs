using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Practise15
{
    public class MyClass
	{
		public string FName;
		public string SName;
		public string IIN;
		private DateTime Birthday = DateTime.Now;

		// Преобразуем subjects в свойство
		public List<string> Subjects { get; set; } = new List<string>();

		

		public void AddSub(string values)
		{
			Subjects.Add(values);
		}

		public void PrintInfo()
		{
			Console.WriteLine("Имя студента: {0}, Фамилия студента: {1}", FName, SName);
			Console.WriteLine("Предметы");
			int counter = 1;
			foreach (var sub in Subjects)
			{
				Console.WriteLine("{0}. Предмет: {1}", counter, sub);
				counter++;
			}
		}
		private void FullInfo()
		{
			Console.WriteLine("Имя студента: {0}, Фамилия студента: {1}, ИИН: {2}, Дата рождения: {3}", FName, SName, IIN, Birthday);
			Console.WriteLine("Предметы");
			int counter = 1;
			foreach (var sub in Subjects)
			{
				Console.WriteLine("{0}. Предмет: {1}", counter, sub);
				counter++;
			}
		}

	}
}
