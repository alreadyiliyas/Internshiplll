using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary.Homework12
{
	public class Racing
	{
		public delegate void RaceDelegate();

		public event RaceDelegate StartRaceEvent;
		public event RaceDelegate FinishRaceEvent; // Добавим событие завершения гонки

		public void StartRace()
		{
			StartRaceEvent?.Invoke();

			// Имитация времени гонки
			Thread.Sleep(2000);

			// Завершение гонки после определенного времени
			FinishRaceEvent?.Invoke();
		}
	}
}
