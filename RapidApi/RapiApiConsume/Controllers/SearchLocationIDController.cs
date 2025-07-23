using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapiApiConsume.Models;
using RapidApiConsume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RapidApiConsume.Controllers
{
    public class SearchLocationIDController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string cityName)
        {
            string query = string.IsNullOrEmpty(cityName) ? "istanbul" : cityName;

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query={query}"),
                Headers =
            {
                { "x-rapidapi-key", "a2c59b777amshbac4d09014df224p1e74e9jsn579984440edc" },
                { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
            },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var root = JsonConvert.DeserializeObject<BookingApiLocationSearchRoot>(body);

                // İlk kaydın ID’sini alıyoruz
                var firstId = root.data?.FirstOrDefault()?.dest_id;

                return View(model: firstId); // Tek ID'yi View'e gönderiyoruz
            }
        }
    }
}