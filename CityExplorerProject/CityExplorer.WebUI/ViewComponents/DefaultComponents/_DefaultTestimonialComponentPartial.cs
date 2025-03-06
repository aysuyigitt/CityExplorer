using Microsoft.AspNetCore.Mvc;

namespace CityExplorer.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultTestimonialComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}