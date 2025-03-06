using AutoMapper;
using CityExplorer.BusinessLayer.Service;
using CityExplorer.DtoLayer.CityMapper;
using CityExplorer.DtoLayer.SocialMediaMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CityExplorer.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultCityComponentPartial : ViewComponent
    {
      private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultCityComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
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
    }
}
