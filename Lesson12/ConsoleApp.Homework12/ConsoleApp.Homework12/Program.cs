using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Homework12;

namespace ConsoleApp.Homework12
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Задание 1");
			Ex1();
		}
		static void Ex1()
		{
			Racing racingGame = new Racing();
			SimpleCars simpleCars = new SimpleCars("Hyandai", 1800, 10);
			SportCars sportsCar = new SportCars("Ferrari", 1500, 10);
			CargoCars passengerCar = new CargoCars("Toyota", 2000, 8);
			Bus bus = new Bus("Mercedes", 8000, 6);

			racingGame.StartRaceEvent += bus.Move;
			racingGame.StartRaceEvent += simpleCars.Move;
			racingGame.StartRaceEvent += sportsCar.Move;
			racingGame.StartRaceEvent += passengerCar.Move;

			// Добавим обработчик завершения гонки
			racingGame.FinishRaceEvent += () =>
			{
				Console.WriteLine("Гонка завершена!");
			};
			racingGame.StartRace();
		}

	}
}
