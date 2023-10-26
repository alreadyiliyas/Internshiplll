using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Example.Controllers
{
    [Route("api/currency")]
    [ApiController]
    public class APIForCurrency : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public APIForCurrency()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://suggestions.dadata.ru/suggestions/api/4_1/rs/findById/currency");
        }

        [HttpGet("exchangeRate/{selectedCurrency}")]
        public async Task<IActionResult> GetExchangeRate(string selectedCurrency)
        {
            try
            {
                var jsonReq = JsonConvert.SerializeObject(new
                {
                    query = selectedCurrency
                });

                var req = new HttpRequestMessage(HttpMethod.Post, "");
                req.Content = new StringContent(jsonReq, Encoding.UTF8, "application/json");
                req.Headers.Add("Authorization", "Token 2a490eda0f9ce9555ec129f862b71e3a0aa93e61");

                var res = await _httpClient.SendAsync(req);
                res.EnsureSuccessStatusCode();


                var jsonResponse = await res.Content.ReadAsStringAsync();
                var result = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseModel>(jsonResponse);
                
                return Ok(result);
            }
            catch (HttpRequestException)
            {
                return StatusCode(500, "Ошибка при выполнении запроса к внешнему API");
            }
        }
    }

    public class ResponseModel
    { 
        public List<SuggestionModel> Suggestions { get; set; }
    }
    public class SuggestionModel
    {
        public string Value { get; set; }
        public string UnrestrictedValue { get; set; }
        public DataModel Data { get; set; }
    }
    public class DataModel
    {
        public string Code { get; set; }
        public string StrCode { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }

}
