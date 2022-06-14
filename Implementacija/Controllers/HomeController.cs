using Microsoft.AspNetCore.Mvc;
using Projekat___Parking.Models;
using System.Diagnostics;

namespace Projekat___Parking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult OtvoriParking()
        {
            return View();
        }
        public IActionResult Rezervisi()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Korisnik()
        {
            return View();
        }
        public IActionResult Uvid()
        {
            return View();
        }
        public IActionResult Parking(int n)
        {
           
            ViewData["BrojParkinga"] = n;
            return View();
        }
        public IActionResult VIPParking(int n)
        {

            ViewData["BrojParkinga"] = n;
            return View();
        }
        public IActionResult VIPKorisnik()
        {
            return View();
        }
        public IActionResult Zauzmi()
        {
            return View();
        }
        public IActionResult Radnik()
        {
            return View();
        }
        public IActionResult Vlasnik()
        {
            return View();
        }



        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}