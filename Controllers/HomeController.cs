using Microsoft.AspNetCore.Mvc;

namespace WelcomeAsp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Welcome()
        {
            ViewBag.Message = "Welcome to ASP.NET Core!";
            ViewBag.CurrentTime = DateTime.Now.ToString("F");
            return View();
        }

        public IActionResult Index()
        {
            return RedirectToAction("Welcome");
        }
    }
}
