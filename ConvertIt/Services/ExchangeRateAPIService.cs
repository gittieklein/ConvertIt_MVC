using ConvertIt.Models;
using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;

namespace ConvertIt.Services
{
    public class ExchangeRateAPIService
    {      
       // static HttpClient client = new HttpClient();

        public double GetCurrencyExchange(int amount, string from, string to)//public async Task<double> GetCurrencyExchange(int amount, string from, string to)
        {
            string url = $"https://v3.exchangerate-api.com/pair/bfe4ced123054d17e4048402/{from}/{to}";

            var data = JsonConvert.DeserializeObject<ExchangeRateData>(GetResponse("https://v3.exchangerate-api.com/pair/bfe4ced123054d17e4048402/" + from + "/" + to));

            double num = Double.Parse(data.rate) * amount;
            return Math.Round(num, 2);
        }

        private string GetResponse(string url)
        {
            var apiResult = "";
            using (var httpClient = new HttpClient())
            {
                HttpMethod httpVerb = HttpMethod.Get;

               var request = new HttpRequestMessage(httpVerb, url);

                //ServicePointManager.ServerCertificateValidationCallback = ((sender, cert, chain, errors) => true);

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
