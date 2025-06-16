using System.Diagnostics;
using lap09.Models;
using Microsoft.AspNetCore.Mvc;

namespace lap09.Controllers
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
