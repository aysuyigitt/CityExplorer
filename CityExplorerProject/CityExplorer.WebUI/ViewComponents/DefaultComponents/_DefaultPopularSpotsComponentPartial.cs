using Microsoft.AspNetCore.Mvc;

namespace CityExplorer.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultPopularSpotsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

