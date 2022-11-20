using Microsoft.AspNetCore.Mvc;

namespace SocialMediaWeb.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
