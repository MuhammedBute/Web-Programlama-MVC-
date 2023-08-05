using MyWebApplicationMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApplicationMVC.Controllers
{
    public class HastaController : Controller
    {
        public IActionResult Hasta()
        {
            return View();
        }

        public IActionResult Poliklinik()
        {
            return View();
        }
        public IActionResult Doktor()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
