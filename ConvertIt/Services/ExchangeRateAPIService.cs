using ConvertIt.Models;
using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using ConvertIt.Models.Currency;
using System.Collections.Generic;

namespace ConvertIt.Services
{
    public class ExchangeRateAPIService
    {
        public string APIKey = "bfe4ced123054d17e4048402";

        public double GetCurrencyExchange(int amount, string from, string to)
        {
            string url = $"https://v3.exchangerate-api.com/pair/{APIKey}/{from}/{to}";

            ExchangeRateData data = JsonConvert.DeserializeObject<ExchangeRateData>(GetResponse(url));

            double num = Double.Parse(data.rate) * amount;
            return Math.Round(num, 2);
        }

        public List<AllExchangeRates> GetAllExchangeRates(List<String> from)
        {
            List<AllExchangeRates> data = new List<AllExchangeRates>();
            foreach(string currency in from)
            {
                string url = $"https://v3.exchangerate-api.com/bulk/{APIKey}/{currency}";
                data.Add(JsonConvert.DeserializeObject<AllExchangeRates>(GetResponse(url)));
            }

            return data;
        }

        private string GetResponse(string url)
        {
            var apiResult = "";
            using (var httpClient = new HttpClient())
            {
                HttpMethod httpVerb = HttpMethod.Get;

               var request = new HttpRequestMessage(httpVerb, url);

                var task = httpClient.SendAsync(request).ContinueWith((taskWithMsg) =>
                {
                    var response = taskWithMsg.Result;
                    if (!response.IsSuccessStatusCode)
                    {
                        var error = response.Content.ReadAsStringAsync().Result;
                        throw new Exception("Error calling API: " + response.StatusCode + " - " + response.ReasonPhrase + Environment.NewLine + error + Environment.NewLine + " url " + url);
                    }
                    apiResult = response.Content.ReadAsStringAsync().Result;
                });

                task.Wait();
            }
            return apiResult;
        }
    }
}
