using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practise14
{
	public class Ex1<TKey, TValue>
	{
		Dictionary<TKey, TValue> dictText = new Dictionary<TKey, TValue>();

		public void AddToDict(TKey key, TValue value)
		{
			dictText.Add(key, value);
		}

		public void Display()
		{
			foreach (var kvp in dictText)
			{
				Console.WriteLine("Ключ: {0}, Значение: {1}", kvp.Key, kvp.Value);
			}
		}
	}
}
