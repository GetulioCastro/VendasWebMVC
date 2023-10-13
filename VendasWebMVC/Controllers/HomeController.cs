using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VendasWebMVC.Models.ViewModels;

namespace VendasWebMVC.Controllers
{
    public class HomeController : Controller
    {
        public readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Departamento() => View(Departamento);

        public IActionResult Sobre()
        {
            ViewData["Message"] = "Projeto sendo construído para estudar Asp.Net Core - MVC";

            return View();
        }
        public IActionResult Privacidade()
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