using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment2.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Hobbies()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

    }
}
