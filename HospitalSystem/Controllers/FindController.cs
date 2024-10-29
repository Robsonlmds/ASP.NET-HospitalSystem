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
            string[] tagsViews = { "fale conosco+TalkToUs+", "conosco+TalkToUs", "quero contratar+Hire+Hospital", "paciente+RegistrationPage-P+Register", "colaborador+RegistrationPage-C+Register", "cadastroRegistrationPage-P+Register", "sobre+Readme+Register", "readme+Readme+Register", "Home+Index+Hospital", "Pagina inicial+Index+Hospital" };

            foreach (string x in tagsViews)
            {
                if (x.Contains(tempFind))
                {
                    string[] tempTags = x.Split("+");

                    var view = tempTags[1].Replace(" ","");
                    var controller = tempTags[2].Replace(" ","");

                    return RedirectToAction(view, controller);
                    /*Pagina inicial+HomePage + Hospital*/

                  /*  return View("Views/Hospital/HomePage.cshtml");*/
                }
            }

            return View("Views/Hospital/HomePage.cshtml");
        }

    }
}
