using CityExplorer.DtoLayer.CategoryDetailMapper;
using CityExplorer.DtoLayer.CategoryMapper;
using CityExplorer.DtoLayer.CityDetailMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace CityExplorer.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CategoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> CategoryDetail(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:15246/api/CategoryDetails/GetCategoryDetailByCityId?id=" + id);

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var cities = JsonConvert.DeserializeObject<List<ResultCategoryDetailDto>>(jsonData); 
                return View(cities);
            }
            return View();
        }
    }
    }

