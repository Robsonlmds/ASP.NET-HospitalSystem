using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Diagnostics.CodeAnalysis;

namespace HospitalSystem.Controllers
{
    public class FindController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Find(string tempFind)
        {
            string[] tagsViews = { "fale conosco+TalkToUs", "conosco+TalkToUs", "quero contratar+Hire", "paciente+RegistrationPage-P", "colaborador+RegistrationPage-C", "cadastroRegistrationPage-P", "sobre+Readme", "readme+Readme", "Home+HomePage", "Pagina inicial+HomePage" };

            foreach (string x in tagsViews)
            {
                if (tempFind.Contains(x) == true)
                {
                    string[] tempTags = x.Split("+");

                    var view = tempTags[0];
                    var controller = tempTags[1];

                    return View(view+controller);
                }
            }

            return View("Views/Hospital/HomePage.cshtml");
        }

    }
}
