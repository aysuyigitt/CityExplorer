using Microsoft.AspNetCore.Mvc;

namespace CityExplorer.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
