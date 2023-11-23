using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Homework12
{
	public abstract class Car
	{
		public string Model { get; set; }
		public int Weight { get; set; }
		public int Speed { get; set; }
		public string Condition { get; set; }

		public event Action<string> FinishEvent; // Событие при финише

		protected Car(string model, int weight, int speed)
		{
			Model = model;
			Weight = weight;
			Speed = speed;
			Condition = "Идет на старт"; // Изначальное состояние
		}

		public abstract void Move(); // Абстрактный метод для передвижения автомобиля

		protected void OnFinish(string winner)
		{
			FinishEvent?.Invoke($"Гонки завершены! Победил автомобиль: {winner}");
		}
	}
}
