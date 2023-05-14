using CyberPunk2020.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CyberPunk2020.Controllers
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

        public IActionResult RockerBoys()//
        {
            return View();
        }

        public IActionResult Solos()//
        {
            return View();
        }
        public IActionResult NetRunners()//
        {
            return View();
        }

        public IActionResult Techies()//
        {
            return View();
        }

        public IActionResult Medias()//
        {
            return View();
        }

        public IActionResult Cops()//
        {
            return View();
        }

        public IActionResult Corpos()//
        {
            return View();
        }

        public IActionResult Fixers()//
        {
            return View();
        }

        public IActionResult Nomads()//
        {
            return View();
        }
    }
}