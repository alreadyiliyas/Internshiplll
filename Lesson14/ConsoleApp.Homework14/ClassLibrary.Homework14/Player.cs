using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Homework14
{
	public class Player
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Karta> Deck { get; set; } = new List<Karta>();

		public Karta PlayCard()
		{
			if (Deck.Count == 0)
			{
				Console.WriteLine("{0} не имеет больше карт!", Name);
				return null;
			}

			Karta card = Deck.First();
			Deck.Remove(card);
			return card;
		}


		public void AddToDeck(List<Karta> cards)
		{
			Deck.AddRange(cards);
		}
	}
}
