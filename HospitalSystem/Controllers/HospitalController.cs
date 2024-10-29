using Microsoft.AspNetCore.Mvc;

namespace HospitalSystem.Controllers
{
    public class HospitalController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View("HomePage");
        }

        [HttpGet]
        public IActionResult Readme()
        {
            return View("Readme");
        }

        [HttpGet]
        public IActionResult Hire()
        {
            return View("Hire");
        }

        [HttpPost]
        public IActionResult Index(string inputUsername)
        {
            return View();
        }


    }
}
