using Microsoft.AspNetCore.Mvc;
using SimpleWebSite.Models;
using System.Diagnostics;

namespace SimpleWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Greet()
        {
            return View();
        }


        public IActionResult jQueryGreet()
        {
            return View();
        }

        public IActionResult FetchGreet()
        {
            return View();
        }

        public IActionResult CheckName()
        {
            return View();
        }

        public IActionResult jQueryCheckName()
        {
            return View();
        }

        public IActionResult FetchCheckName()
        {
            return View();
        }
    }
}