using CityExplorer.DtoLayer.BlogMapper;
using CityExplorer.DtoLayer.CategoryMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CityExplorer.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultBlogComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultBlogComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:15246/api/Blogs");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBlogDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
