using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Homework14
{
	public class Karta
	{
		public EKarta Value { get; set; }
		public EKartaSuit Suit { get; set; }
		public Player Owner { get; set; }
		public Karta(EKarta value, EKartaSuit suit)
		{
			Value = value;
			Suit = suit;
		}
		public static List<Karta> GenerateDeck(List<Player> players)
		{
			List<Karta> deck = new List<Karta>();

			foreach (EKarta value in Enum.GetValues(typeof(EKarta)))
			{
				foreach (EKartaSuit suit in Enum.GetValues(typeof(EKartaSuit)))
				{
					Karta karta = new Karta(value, suit);
					karta.Owner = players.FirstOrDefault();
					deck.Add(karta);
				}
			}

			return deck;
		}
		public void DisplayKarta()
		{
			Console.WriteLine("Карта: {0}, масть: {1}", Value, Suit);
		}
	}
}
