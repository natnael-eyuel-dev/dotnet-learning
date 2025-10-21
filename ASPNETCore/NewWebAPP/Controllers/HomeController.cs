using Microsoft.AspNetCore.Mvc;
using System;

namespace MyFirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/Index
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Home/Greeting?name=YourName
        public IActionResult Greeting(string name)
        {
            ViewData["Name"] = name ?? "Guest";
            return View();
        }

        // [HttpPost]
        public IActionResult Submit(string name)
        {
            // Redirect to Greeting and pass name as route parameter
            Console.WriteLine($"Received: {name}");
            return RedirectToAction("Greeting", new { name = name });
        }
    }
}
