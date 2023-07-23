using Hospital.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hospital.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public ActionResult Index()
        {
            var viewModel = new NewModel
            {
                AvailableBloodGroups = GetAvailableBloodGroups()
            };

            return View(viewModel);
        }
        public ActionResult RegistrationSuccess(RegistrationSuccessViewModel viewModel)
        {
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Register(IFormCollection form)
        {
            // Retrieve form data
            string fullName = form["FullName"];
            string dateOfBirth = form["DateOfBirth"];
            string bloodGroup = form["BloodGroup"];

            ViewBag.FullName = fullName;
            ViewBag.DateOfBirth = dateOfBirth;
            ViewBag.BloodGroup = bloodGroup;
            return View("RegistrationSuccess");
        }
        [HttpPost]
        
        private List<string> GetAvailableBloodGroups()
        {
            return new List<string> { "A+", "B+", "O+", "AB+", "A-", "B-", "O-", "AB-" };
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
    }
}