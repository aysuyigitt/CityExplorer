using CityExplorer.DtoLayer.CategoryMapper;
using CityExplorer.DtoLayer.CityMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CityExplorer.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminCity")]
    public class AdminCityController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminCityController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:15246/api/Cities");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCityDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        [Route("CreateCity")]
        public IActionResult CreateCity()
        {
            return View();
        }
        [HttpPost]
        [Route("CreateCity")]
        public async Task<IActionResult> CreateCity(CreateCityDto createCityDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createCityDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:15246/api/Cities/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminCity", new { area = "Admin" });
            }
            return View();
        }
            [Route("RemoveCity/{id}")]
            public async Task<IActionResult> RemoveCity(int id)
            {
                var client = _httpClientFactory.CreateClient();
                var responseMessage = await client.DeleteAsync("http://localhost:15246/api/Cities?id=" + id);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }
            [HttpGet]
            [Route("UpdateCity/{id}")]
            public async Task<IActionResult> UpdateCity(int id)
            {
                var client = _httpClientFactory.CreateClient();
                var responseMessage = await client.GetAsync($"http://localhost:15246/api/Cities/{id}");
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<UpdateCityDto>(jsonData);
                    return View(values);
                }
                return View();
            }
            [HttpPost]
            [Route("UpdateCity/{id}")]
            public async Task<IActionResult> UpdateCity(UpdateCityDto updateCityDto)
            {
                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(updateCityDto);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PutAsync("http://localhost:15246/api/Cities/", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "AdminCity", new { area = "Admin" });
                }
                return View();
            }
        }
    }

