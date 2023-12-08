using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Practise16
{
	public class Watcher
	{
		private WriteLog logger;

		public string Path { get; set; }

		public Watcher(string path, string logFilePath)
		{
			Path = path;
			logger = new WriteLog(logFilePath);

			FileSystemWatcher watcher = new FileSystemWatcher(path);
			watcher.IncludeSubdirectories = true;
			watcher.EnableRaisingEvents = true;

			// Добавляем обработчики событий
			watcher.Created += OnFileCreated;
			watcher.Deleted += OnFileDeleted;
			watcher.Changed += OnFileChanged;
			watcher.Renamed += OnFileRenamed;
		}

		private void LogToFile(string message)
		{
			logger.WriteToLog(message);
		}

		public void OnFileCreated(object sender, FileSystemEventArgs e)
		{
			string message = "Файл создан: " + e.FullPath;
			Console.WriteLine(message);
			LogToFile(message);
		}

		public void OnFileDeleted(object sender, FileSystemEventArgs e)
		{
			string message = "Файл удален: " + e.FullPath;
			Console.WriteLine(message);
			LogToFile(message);
		}

		public void OnFileChanged(object sender, FileSystemEventArgs e)
		{
			string message = "Файл изменен: " + e.FullPath;
			Console.WriteLine(message);
			LogToFile(message);
		}

		public void OnFileRenamed(object sender, RenamedEventArgs e)
		{
			string message = "Файл переименован: " + e.OldFullPath + " в " + e.FullPath;
			Console.WriteLine(message);
			LogToFile(message);
		}
	}
}
