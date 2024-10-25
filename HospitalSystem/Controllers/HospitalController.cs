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

        [HttpPost]
        public IActionResult Index(string inputUsername)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Readme()
        {
            return View("Readme");
        }


    }
}
