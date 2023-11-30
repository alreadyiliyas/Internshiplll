using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace ConsoleApp.Practise14
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Ex1<int, string> ex = new Ex1<int, string>();
			string text = "Вот дом, Который построил Джек. А это пшеница, Кото­рая в темном чулане хранится В доме, Который построил Джек. А это веселая птица­ синица, Которая часто вору­ет пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";

			string[] words = text.Split(' ')
					 .Select(word => word.Trim('.', ',', '-'))
					 .ToArray();

			Dictionary<string, int> wordCount = new Dictionary<string, int>();

			for (int i = 0; i < words.Length; i++)
			{
				ex.AddToDict(i, words[i]);
			}
			ex.Display();
		}
	}
}
