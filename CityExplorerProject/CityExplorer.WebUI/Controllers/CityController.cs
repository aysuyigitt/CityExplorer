using CityExplorer.DataAccessLayer.Concrete;
using CityExplorer.DtoLayer.CityDetailMapper;
using CityExplorer.DtoLayer.CityMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace CityExplorer.WebUI.Controllers
{
    public class CityController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CityController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> CityDetail(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:15246/api/CityDetails/GetCityDetailByCityId?id=" +id);

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var cities = JsonConvert.DeserializeObject<List<ResultCityDetailDto>>(jsonData); 
                return View(cities);
            }
            return View();
        }

    }
}
