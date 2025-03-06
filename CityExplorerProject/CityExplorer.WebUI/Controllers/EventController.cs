using CityExplorer.DtoLayer.CityDetailMapper;
using CityExplorer.DtoLayer.EventDetailMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CityExplorer.WebUI.Controllers
{
    public class EventController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public EventController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> EventDetail(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:15246/api/EventDetails/GetEventDetailByEventId?id=" + id);

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var cities = JsonConvert.DeserializeObject<List<ResultEventDetailDto>>(jsonData); 
                return View(cities);
            }
            return View();
        }
        
    }
}
