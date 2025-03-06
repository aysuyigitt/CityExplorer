using CityExplorer.DtoLayer.BlogDetailMapper;
using CityExplorer.DtoLayer.CityDetailMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CityExplorer.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BlogController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult>BlogDetail(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:15246/api/BlogDetails/GetBlogDetailByBlogId?id=" + id);

            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var blogs = JsonConvert.DeserializeObject<List<ResultBlogDetailDto>>(jsonData);
                return View(blogs);
            }
            return View();  

        }
    }
}
