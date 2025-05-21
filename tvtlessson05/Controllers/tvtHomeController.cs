using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tvtlessson05.Models;
using tvtlessson05.Models.DataModels;
namespace tvtlessson05.Controllers
{
    public class TvtHomeController : Controller
    {
        private readonly ILogger<TvtHomeController> _logger;

        public TvtHomeController(ILogger<TvtHomeController> logger)
        {
            _logger = logger;
        }

        // GET: /TvtHome/Index
        public IActionResult TvtIndex()
        {
            return View();
        }

        // GET: /TvtHome/About
        public IActionResult TvtAbout()
        {
            tvtMember tvtMember = new tvtMember ();
            tvtMember.TvtMemberId = Guid.NewGuid().ToString();
            tvtMember.TvtUserName = "ta van tan";
            tvtMember.TvtPassword = "12345";
            tvtMember.TvtFullName = "ta van tan";
            tvtMember.TvtEmail = "tavantan113344@gmail.com";
            

            return View(tvtMember);
        }

        // GET: /TvtHome/Privacy
        public IActionResult Privacy()
        {
            return View();
        }

        // Error handler
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel 
            { 
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier 
            });
        }
    }
}
