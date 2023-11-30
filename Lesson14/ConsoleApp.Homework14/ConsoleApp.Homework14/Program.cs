using ClassLibrary.Homework14;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Homework14
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Game game = new Game();
			Player player1 = new Player();
			Player player2 = new Player();

			player1.Id = 1;
			player1.Name = "Iliyas";
			player2.Id = 2;
			player2.Name = "Islam";

			game.AddPlayers(player1);
			game.AddPlayers(player2);
			game.PlayersKarts();

			game.StartGame();
		}
	}
}
