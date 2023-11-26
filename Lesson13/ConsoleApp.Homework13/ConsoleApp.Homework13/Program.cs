using ClassLibrary.Homework13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp.Homework13
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("!!!!!!!!!!!!!!!Стоит Thread.Sleep для методов!!!!!!!!!!!!!!!!!!!!!!");
			Queue<IClient> clientQueue = new Queue<IClient>();
			AddClientToQueue(clientQueue, 1, "Iliyas", DateTime.Now);
			AddClientToQueue(clientQueue, 2, "Islam", DateTime.Now);
			AddClientToQueue(clientQueue, 3, "Elkhan", DateTime.Now);

			Console.WriteLine("Все клиенты: ");
			ShowAllCli(clientQueue);

			Console.WriteLine("Выберите роль: \n1. admin \n2. client");
			string choiseRole = Console.ReadLine();

			if (choiseRole == Role.admin.ToString())
			{
				Administration(clientQueue);
				ShowAllCli(clientQueue);
			}
			else if (choiseRole == Role.client.ToString())
			{

			}
		}
		static void AddClientToQueue(Queue<IClient> clientQueue, int id, string name, DateTime dateOfBirthday)
		{
			Client newClient = new Client();
			newClient.Id = id;
			newClient.Name = name;
			newClient.DateOfBirthday = dateOfBirthday;
			newClient.AddQueue(clientQueue);
		}
		static void Administration(Queue<IClient> clientQueue)
		{
			Console.WriteLine("Выберите клиента для обслуживания");
			string ClientName = Console.ReadLine();

			for (int i = 0; i < clientQueue.Count; i++)
			{
				var client = clientQueue.ElementAt(i);

				if (ClientName == client.Name)
				{
					Console.WriteLine($"Выбран клиент: {client.Name} с Id: {client.Id}");
					Console.WriteLine("1. Открыть депозит");
					Console.WriteLine("2. Выдать кредит");

					int choice = Convert.ToInt32(Console.ReadLine());
					if (choice == 1)
					{
						ConsultationServices(client);
						OpenDeposits(client);
					}
					else if (choice == 2)
					{
						ConsultationServices(client);
						CreditService(client);
					}
					else
					{
						Console.WriteLine("Ошибка");
					}
					client.StateQueue = true;
				}
			}
			
		}
		static void ShowAllCli(Queue<IClient> clientQueue)
		{
			foreach (var client in clientQueue)
			{
				client.ShowAllClient();
			}
		}
		static void ConsultationServices(IClient client)
		{
			client.ConsultationService();
		}
		static void CreditService(IClient client)
		{
			client.CreditService();
		}
		static void OpenDeposits(IClient client)
		{
			client.OpenDeposit();
		}
	}
}
