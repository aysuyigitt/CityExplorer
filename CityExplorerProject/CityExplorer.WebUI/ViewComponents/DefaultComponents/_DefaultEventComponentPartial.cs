using CityExplorer.DtoLayer.CityMapper;
using CityExplorer.DtoLayer.EventMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CityExplorer.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultEventComponentPartial: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultEventComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:15246/api/Events");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultEventDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}