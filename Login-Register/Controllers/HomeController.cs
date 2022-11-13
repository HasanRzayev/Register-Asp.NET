using Login_Register.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Login_Register.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
        [HttpPost, ActionName("Login")]
        public IActionResult Login(User user)
        {
            if(!ModelState.IsValid) return View();
            return View();
        }
    }
}