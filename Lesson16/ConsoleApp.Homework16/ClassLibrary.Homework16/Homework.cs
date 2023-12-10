using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ClassLibrary.Homework16
{
	public class Homework
	{
		public string path { get; set; }
		private string logFilePath;
		int choise;

		public Homework(string path)
		{
			this.path = path;
			this.logFilePath = Path.Combine(path, "log.txt");

			if (Directory.Exists(path))
			{
				while (true)
				{
					Console.WriteLine("Логирование действий идет в той же директории, которую указал пользователь");
					Console.WriteLine("Выберите действие: \r\n0. Для завершения приложения. \r\n1. Просмотр Содержимого Директории:\r\n2. Создание Файла/Директории:\r\n3. Удаление Файла/Директории:\r\n4. Копирование и Перемещение Файлов и Директорий:\r\n5. Чтение и Запись в Файл:");
					choise = Convert.ToInt32(Console.ReadLine());
					DirectoryInfo dirInfo = new DirectoryInfo(path);
					if (choise == 0) { break; }
					else if (choise == 1) { ShowDirAndFiles(); }
					else if (choise == 2) { CreateFilesOrDir(dirInfo); }
					else if (choise == 3) { DeleteFilesOrDir(dirInfo); }
					else if (choise == 4) { CopyOrMoveFilesOrDir(dirInfo); }
					else if (choise == 5) { ReadOrWrite(dirInfo); }
				}
			}
			else { Console.WriteLine("Такой директории нет!"); }
		}

		public void ShowDirAndFiles()
		{
			Console.WriteLine("Папки: ");
			string[] dirs = Directory.GetDirectories(path);

			foreach (var dir in dirs)
			{
				Console.WriteLine(dir);
			}

			Console.WriteLine("Файлы: ");
			string[] files = Directory.GetFiles(path);

			foreach (string file in files)
			{
				Console.WriteLine(file);
			}
			LogEvent("Пользователь просмотрел содержимое директории");
		}

		public void CreateFilesOrDir(DirectoryInfo dirInfo)
		{
			Console.WriteLine("Создать \r\n1. Директорию \r\n2. Файл");
			choise = Convert.ToInt32(Console.ReadLine());
			if (choise == 1)
			{
				Console.Write("Введите название директории (папки): ");
				string DirName = Console.ReadLine();

				string subDirPath = Path.Combine(dirInfo.FullName, DirName);

				if (Directory.GetDirectories(dirInfo.FullName).Any(d => string.Equals(d, subDirPath, StringComparison.OrdinalIgnoreCase)))
				{
					Console.WriteLine("Такая директория существует!");
				}
				else
				{
					Directory.CreateDirectory(subDirPath);
					Console.WriteLine("Директория {0} успешно создана", DirName);
				}
			}
			else if (choise == 2)
			{
				Console.Write("Введите название файла: ");
				string FileName = Console.ReadLine();
				string filePath = Path.Combine(dirInfo.FullName, FileName);

				if (File.Exists(filePath))
				{
					Console.WriteLine("Такой файл существует!");
				}
				else
				{
					using (StreamWriter sw = File.CreateText(filePath + ".txt"))
					{
						sw.WriteLine();
					}

					Console.WriteLine("Файл {0} успешно создан", FileName);

				}
			}
			LogEvent("Пользователь создал файл или директорию");
		}

		public void DeleteFilesOrDir(DirectoryInfo dirInfo)
		{
			Console.WriteLine("Удалить: \r\n1. Файл \r\n2. Папку");
			choise = Convert.ToInt32(Console.ReadLine());
			if (choise == 1)
			{
				Console.Write("Название файла: ");
				string FileName = Console.ReadLine();
				string filePath = Path.Combine(dirInfo.FullName, FileName + ".txt");

				if (!File.Exists(filePath))
				{
					Console.WriteLine("Такой файл не существует!");
				}
				else
				{
					File.Delete(filePath);
					Console.WriteLine("Файл {0} успешно удален", FileName);
				}
			}
			else if (choise == 2)
			{
				Console.Write("Название директории: ");
				string DirName = Console.ReadLine();
				string dirPath = Path.Combine(dirInfo.FullName, DirName);

				if (Directory.Exists(dirPath))
				{
					Directory.Delete(dirPath, true);
					Console.WriteLine("Директория {0} успешно удалена", DirName);
				}
				else
				{
					Console.WriteLine("Такой директории не существует!");
				}
			}
			else { Console.WriteLine("Ошибка выбора!"); }
			LogEvent("Пользователь удалил файл или директорию");
		}

		public void CopyOrMoveFilesOrDir(DirectoryInfo dirInfo)
		{
			Console.WriteLine("1. Копировать файл \r\n2. Копировать папку \r\n3. Переместить файл \r\n4. Переместить папку");
			int choise = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите название файла или папки: ");
			string itemName = Console.ReadLine();
			string sourcePath = Path.Combine(dirInfo.FullName, itemName);

			if (choise == 1 || choise == 3) // Копирование или перемещение файла
			{
				Console.Write("Введите путь для копирования/перемещения файла: ");
				string destinationPath = Console.ReadLine();

				if (File.Exists(sourcePath))
				{
					string destinationFilePath = Path.Combine(destinationPath, Path.GetFileName(itemName));

					if (choise == 1)
					{
						File.Copy(sourcePath, destinationFilePath, true);
						Console.WriteLine("Файл успешно скопирован");
					}
					else if (choise == 3)
					{
						File.Move(sourcePath, destinationFilePath);
						Console.WriteLine("Файл успешно перемещен");
					}
				}
				else
				{
					Console.WriteLine("Такого файла не существует!");
				}
			}
			else if (choise == 2 || choise == 4) // Копирование или перемещение папки
			{
				Console.Write("Введите путь для копирования/перемещения папки: ");
				string destinationPath = Console.ReadLine();

				if (Directory.Exists(sourcePath))
				{
					string destinationDirPath = Path.Combine(destinationPath, itemName);

					if (choise == 2)
					{
						CopyDirectory(sourcePath, destinationDirPath);
						Console.WriteLine("Папка успешно скопирована");
					}
					else if (choise == 4)
					{
						Directory.Move(sourcePath, destinationDirPath);
						Console.WriteLine("Папка успешно перемещена");
					}
				}
				else
				{
					Console.WriteLine("Такой папки не существует!");
				}
			}
			else
			{
				Console.WriteLine("Ошибка выбора!");
			}
			LogEvent("Пользователь скопировал или переместил файл или директорию");
		}

		private static void CopyDirectory(string sourceDir, string destinationDir)
		{
			if (!Directory.Exists(destinationDir))
			{
				Directory.CreateDirectory(destinationDir);
			}

			foreach (string file in Directory.GetFiles(sourceDir))
			{
				string destFile = Path.Combine(destinationDir, Path.GetFileName(file));
				File.Copy(file, destFile, true);
			}

			foreach (string subDir in Directory.GetDirectories(sourceDir))
			{
				string destDir = Path.Combine(destinationDir, Path.GetFileName(subDir));
				CopyDirectory(subDir, destDir);
			}
		}

		public void ReadOrWrite(DirectoryInfo dirInfo)
		{
			Console.WriteLine("1. Читать из файла \r\n2. Записать в файл");
			int choise = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите название файла: ");
			string fileName = Console.ReadLine();
			string filePath = Path.Combine(dirInfo.FullName, fileName);

			if (choise == 1) // Читать из файла
			{
				if (File.Exists(filePath))
				{
					string content = File.ReadAllText(filePath);
					Console.WriteLine("Содержимое файла {0}:\n{1}", fileName, content);
				}
				else
				{
					Console.WriteLine("Такого файла не существует!");
				}
			}
			else if (choise == 2) // Записать в файл
			{
				Console.Write("Введите текст для записи в файл: ");
				string content = Console.ReadLine();

				File.WriteAllText(filePath, content);
				Console.WriteLine("Текст успешно записан в файл {0}", fileName);
			}
			else
			{
				Console.WriteLine("Ошибка выбора!");
			}
			LogEvent("Пользователь прочитал или записал в файл");
		}

		public void WriteLog()
		{
			Console.Write("Введите путь к директории для логирования: ");
			string logDirPath = Console.ReadLine();

			// Создание директории, если она не существует
			if (!Directory.Exists(logDirPath))
			{
				Directory.CreateDirectory(logDirPath);
				Console.WriteLine("Директория для логирования создана.");
			}

			Console.Write("Введите название файла для логирования: ");
			string logFileName = Console.ReadLine();
			string logFilePath = Path.Combine(logDirPath, logFileName);

			using (StreamWriter sw = File.AppendText(logFilePath))
			{
				sw.WriteLine("Логирование начато: {0}", DateTime.Now);

				// Внесите изменения в логирование в зависимости от ваших требований
				// Например, можно использовать методы WriteLine, Write и другие методы StreamWriter

				sw.WriteLine("Логирование завершено: {0}", DateTime.Now);

				Console.WriteLine("Логирование в файл {0} завершено.", logFileName);
			}
		}

		private void LogEvent(string message)
		{
			using (StreamWriter sw = File.AppendText(logFilePath))
			{
				sw.WriteLine("{0}: {1}", DateTime.Now, message);
			}
		}
	}
}
