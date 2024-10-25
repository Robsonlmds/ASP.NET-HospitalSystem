using Microsoft.AspNetCore.Mvc;

namespace HospitalSystem.Controllers
{
    public class RegisterController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View("Views/Hospital/RegistrationPage.cshtml");
        }

        [HttpPost]
        public IActionResult Index(string inputUsername, string inputPassword, bool inputCheckInput)
        {
            string username = inputUsername;
            string password = inputPassword;
            bool checkInput = inputCheckInput;

            return View("RegistrationPage");
        }
    }
}
