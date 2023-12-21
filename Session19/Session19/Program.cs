using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Session19.DAL;
using System.Xml.Linq;
using Session19.DAL.Model;
using System.Collections;
using System.Security.Principal;
using Newtonsoft.Json.Linq;
using Session19.BLL.Model;
using Session19.BLL;

namespace Session19
{
	class Program
	{
		static string path = ConfigurationManager
			.ConnectionStrings["DefaultConnection"]
			.ConnectionString;

		static string apiKey = ConfigurationManager
			.ConnectionStrings["ApiKey"]
			.ConnectionString;
		static string apiUrl = ConfigurationManager
			.ConnectionStrings["ApiUrl"]
			.ConnectionString;

		static async Task Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Выбрать действие: \n1. Регистрация \n2. Авторизоваться \n3.Остановить");
				int choose = Convert.ToInt32(Console.ReadLine());

				if (choose == 1)
				{
					RegisterAccount();
				}
				else if (choose == 2)
				{
					await Authorize();
				}
				else if(choose == 3) { } 
				{ 
					Console.WriteLine("Программа остановилась!");
					break;
				}
			}
			
		}

		static void RegisterAccount()
		{
			var accountService = new ServiceAccount(path);

			Console.WriteLine("Введите логин:");
			string login = Console.ReadLine();

			Console.WriteLine("Введите пароль:");
			string password = Console.ReadLine();

			var registrationResult = accountService.RegisterAccount(new AccountDTO
			{
				Login = login,
				Password = password
			});

			Console.WriteLine("Регистрация: {0}", registrationResult.message);

			
		}

		static async Task Authorize()
		{
			var accountService = new ServiceAccount(path);

			Console.WriteLine("Введите логин:");
			string login = Console.ReadLine();

			Console.WriteLine("Введите пароль:");
			string password = Console.ReadLine();

			var authorizationResult = accountService.AuthorizationClient(new AccountDTO
			{
				Login = login,
				Password = password
			});

			if (authorizationResult != null)
			{
				await ApiLoad();
			}
			else
			{
				Console.WriteLine("Ошибка пароль или логин не правильный");
			}
		}

		static async Task ApiLoad()
		{
			var currencyService = new ServiceCurrency(path);

			List<Currency> currencies = currencyService.GetAllCurrencies();

			Console.WriteLine("Выберите действие: \n1. Вывести все актуальные валюты. \n2. Перевести из одной валюты в другую \n3.Актуализировать данные:");
			int choise = Convert.ToInt32(Console.ReadLine());

			if (choise == 1)
			{
				foreach (var currency in currencies)
				{
					Console.WriteLine($"{currency.CurrencyCode}: {currency.CurrencyValue}");
				}
			}
			else if (choise == 2)
			{
				Console.Write("Введите 1 код валюты: ");
				string FirstCode = Console.ReadLine();
				Console.Write("Введите 2 код валюты: ");
				string SecondCode = Console.ReadLine();
				Console.Write("Введите сумму: ");
				decimal InputSum = Convert.ToDecimal(Console.ReadLine());


				var selectedCurrenciesFirst = currencies
					.Where(currency => currency.CurrencyCode == FirstCode.ToUpper())
					.Select(currency => currency.CurrencyValue)
					.ToList();

				var selectedCurrenciesSecond = currencies
					.Where(currency => currency.CurrencyCode == SecondCode.ToUpper())
					.Select(currency => currency.CurrencyValue)
					.ToList();

				if (selectedCurrenciesFirst.Count > 0 && selectedCurrenciesSecond.Count > 0)
				{
					decimal sourceRate = selectedCurrenciesFirst.First();
					decimal targetRate = selectedCurrenciesSecond.First();

					decimal result = (InputSum / sourceRate) * targetRate;

					Console.WriteLine($"Переведенная сумма: {result} {SecondCode}");
				}
				else
				{
					Console.WriteLine("Неправильный код");
				}
			}
			else if (choise == 3)
			{
				bool updateResult = await currencyService.UpdateCurrenciesFromApi(apiUrl, apiKey);
				if (updateResult)
				{
					Console.WriteLine("Данные успешно обновлены из API.");
				}
				else
				{
					Console.WriteLine("Ошибка при обновлении данных из API.");
				}
			}
		}
	}
}
