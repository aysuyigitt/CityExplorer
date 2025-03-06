using Microsoft.AspNetCore.Mvc;

namespace CityExplorer.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
