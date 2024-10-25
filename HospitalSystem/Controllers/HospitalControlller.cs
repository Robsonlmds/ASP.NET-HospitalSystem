using Microsoft.AspNetCore.Mvc;

namespace HospitalSystem.Controllers
{
    public class HospitalControlller : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


    }
}
