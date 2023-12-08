using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Practise16
{
	public class WriteLog
	{
		public string Path { get; set; }

		public WriteLog(string path)
		{
			Path = path;
		}

		public void WriteToLog(string message)
		{
			using (StreamWriter sw = File.AppendText(Path))
			{
				sw.WriteLine($"{DateTime.Now}: {message}");
			}
		}
	}
}
