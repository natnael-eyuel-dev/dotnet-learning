using Microsoft.AspNetCore.Mvc;
using ASPNETCoreDI.Services;

namespace ASPNETCoreDI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IEmailService _emailService;

        public AccountController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        // GET: /Account/Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        public IActionResult Register(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                // Simulate account creation logic
                _emailService.SendEmail(email, "Welcome!", "Thank you for registering.");
                return RedirectToAction("Success");
            }

            // Email was empty, return same view
            ViewData["Error"] = "Please enter a valid email.";
            return View();
        }

        // GET: /Account/Success
        public IActionResult Success()
        {
            return View();
        }
    }
}
