using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary.Homework13
{
	public class Client : IClient
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public bool StateQueue {	get; set; }
		public DateTime DateOfBirthday { get; set; }
		public void ShowAllClient()
		{
			if (StateQueue)
			{
				Console.WriteLine("Id: {0}, Имя: {1}, Состояние: Обслужен", Id, Name);
			}
			else
			{
				Console.WriteLine("Id: {0}, Имя: {1}, Состояние: Не обслужен", Id, Name);
			}
			
		}
		public void AddQueue(Queue<IClient> clients) 
		{
			clients.Enqueue(this);
			Console.WriteLine("Клиент: {0} добавлен", Name);
		}
		public void CreditService() 
		{
			Console.WriteLine("Кредит выдан для {0}!", Name);
		}
		public void OpenDeposit() 
		{
			Console.WriteLine("Депозит открыт");
		}
		public void ConsultationService() 
		{
			Console.WriteLine("Клиент: {0} с id: {1} обслуживается", Name, Id);
			//Thread.Sleep((new Random()).Next(3000, 5000));
		}
	}
}
