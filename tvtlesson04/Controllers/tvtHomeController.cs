using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tvtlesson04.Models;

namespace tvtlesson04.Controllers
{
    public class tvtHomeController : Controller
    {
        private readonly ILogger<tvtHomeController> _logger;

        public tvtHomeController(ILogger<tvtHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult tvtIndex()
        {
            return View();
        }

        public IActionResult tvtAbout()
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
