using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary.Homework12
{
	public class SportCars : Car
	{
		public SportCars(string model, int weight, int speed) : base(model, weight, speed) { }

		public override void Move()
		{
			Random random = new Random();
			int distance = 0;

			while (distance < 100)
			{
				Thread.Sleep(100); // Задержка для имитации движения
				distance += Speed;
				Console.WriteLine($"{Model} преодолел {distance} км.");
			}

			Condition = "Финишировал";
			OnFinish(Model);
		}

	}
}
