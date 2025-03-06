using Microsoft.AspNetCore.Mvc;

namespace CityExplorer.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
