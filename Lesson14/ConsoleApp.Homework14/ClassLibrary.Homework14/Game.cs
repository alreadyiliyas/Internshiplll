using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary.Homework14
{
    public class Game
    {
        private List<Player> players { get; set; } = new List<Player>();
        public List<Karta> Karts { get; set; }
		private List<Karta> currentRoundCards;
		public void AddPlayers(Player player)
        {
            players.Add(player);
        }
		public void PlayersKarts()
		{
			Karts = Karta.GenerateDeck(players);
			Karts = Karts.OrderBy(x => Guid.NewGuid()).ToList();
			Karts = Karts.Take(5).ToList();

			foreach (Player player in players)
			{
				player.Deck = new List<Karta>(Karts); 
			}
		}


		public void StartGame()
		{
			currentRoundCards = new List<Karta>();

			while (Karts.Count > 0)
			{
				PlayRound();
			}

			DetermineWinner();
		}

		private void PlayRound()
		{
			foreach (Player player in players)
			{
				Karta card = player.PlayCard();
				if (card != null)
				{
					currentRoundCards.Add(card);
					Console.WriteLine("{0} кладет карту: {1} масть: {2}", player.Name, card.Value, card.Suit);
				}
			}

			if (currentRoundCards.Count > 1)
			{
				Player roundWinner = DetermineRoundWinner(currentRoundCards);
				Console.WriteLine("{0} выигрывает раунд!", roundWinner.Name);

				roundWinner.AddToDeck(currentRoundCards);
			}
			else
			{
				Console.WriteLine("Раунд отменен из-за отсутствия карт у одного из игроков.");
			}

			currentRoundCards.Clear();

			foreach (Player player in players)
			{
				if (player.Deck.Count == 0 && Karts.Count > 0)
				{
					Console.WriteLine("{0} перетасовывает свою колоду", player.Name);
					player.Deck.AddRange(Karts);
					Karts.Clear();
				}
			}
		}



		private Player DetermineRoundWinner(List<Karta> cards)
        {
            return cards.OrderByDescending(c => c.Value).ThenBy(c => c.Suit).First().Owner;
        }

        private void DetermineWinner()
        {
            Player winner = players.OrderByDescending(p => p.Deck.Count).First();
            Console.WriteLine($"{winner.Name} выигрывает игру!");
        }
    }
}
