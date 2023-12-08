using ClassLibrary.Practise16;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practise16
{
	class Program
	{
		static void Main(string[] args)
		{
			//string path = "C:\Users\User\source\repos\CsharpLesson\TestDir";
			//string LogFile = "C:\Users\User\source\repos\CsharpLesson\Lesson16\ConsoleApp.Practise16\ClassLibrary.Practise16\Log\LogFile.txt";

			Console.WriteLine("Введите путь к директории: ");
			string path = Console.ReadLine();

			Console.WriteLine("Введите путь к лог файлу и название: ");
			string logFile = Console.ReadLine();

			if (string.IsNullOrEmpty(path) || string.IsNullOrEmpty(logFile))
			{
				Console.WriteLine("Ошибка: путь к директории или лог файлу не указан");
			}
			else
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(path);
				FileInfo logFileInfo = new FileInfo(logFile);

				if (directoryInfo.Exists)
				{
					if (!logFileInfo.Directory.Exists)
					{
						logFileInfo.Directory.Create(); // создаем директорию, если она не существует
					}

					if (!logFileInfo.Exists)
					{
						using (StreamWriter sw = logFileInfo.CreateText())
						{
							sw.WriteLine("Запись: ");
						}
					}

					Watcher watcher = new Watcher(path, logFile);
					Console.WriteLine($"Отслеживание изменений в каталоге {path}. Нажмите Enter для выхода.");
					Console.ReadLine();
				}
				else
				{
					Console.WriteLine("Такой директории не существует");
				}
			}
		}
		
	}
}
