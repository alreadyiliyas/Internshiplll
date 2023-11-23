using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.Practise12
{
	public class StockExchange
	{
		public delegate void PriceChange(int price);

		public PriceChange PriceChangeHandler { get; set; }

		public void StartEx()
		{
			while(true) {
				int bankOfAmericaPrice = (new Random()).Next(1,100);

				PriceChangeHandler(bankOfAmericaPrice);

				Thread.Sleep(2000);
			}
		}
	}
}
