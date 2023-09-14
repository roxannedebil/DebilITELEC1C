using Microsoft.AspNetCore.Mvc;

namespace DebilITELEC1C.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
