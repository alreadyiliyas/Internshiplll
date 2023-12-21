using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Session19.BLL.Model;
using Session19.DAL;
using Session19.DAL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session19.BLL
{
	public class ServiceCurrency : Service<Currency>
	{

		public ServiceCurrency(string path) : base(path)
		{
		}

		public async Task<bool> UpdateCurrenciesFromApi(string apiUrl, string apiKey)
		{
			try
			{
				string url = $"{apiUrl}?access_key={apiKey}";
				using (var httpClient = new HttpClient())
				{
					HttpResponseMessage response = await httpClient.GetAsync(url);
					response.EnsureSuccessStatusCode();
					//Ожидание ответа с API
					string jsonString = await response.Content.ReadAsStringAsync();
					ApiResponseDTO apiResponse = JsonConvert.DeserializeObject<ApiResponseDTO>(jsonString);
					//Парсим JSON
					JObject json = JObject.Parse(jsonString);
					JObject ratesObject = json["rates"] as JObject;
					//Сохранение в коллекцию
					List<Currency> currencies = ratesObject?.Properties()
						.Select(p => new Currency { CurrencyCode = p.Name, CurrencyValue = p.Value.Value<decimal>(), lastUpdate = DateTime.Now })
						.ToList();

					
					foreach (var currency in currencies)
					{
						repo.Create(currency);
					}
					

					Console.WriteLine("Данные успешно добавлены в базу данных.");
					return true;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Ошибка при обновлении данных из API: {0}", ex.Message);
				return false;
			}
		}


		public List<Currency> GetAllCurrencies()
		{
			// Получение всех валют из базы данных
			DateTime latestDate = repo.GetAll().ListData.Max(currency => currency.lastUpdate);

			return repo.GetAll().ListData
				.Where(currency => currency.lastUpdate == latestDate)
				.ToList();
		}
	}
}
