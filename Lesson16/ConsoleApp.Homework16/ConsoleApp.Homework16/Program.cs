using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Homework16;

namespace ConsoleApp.Homework16
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Путь к директории: ");
			string DirPath = Console.ReadLine();; 
			Homework homework = new Homework(DirPath);
		}
	}
}
