using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Diagnostics.CodeAnalysis;

namespace HospitalSystem.Controllers
{
    public class FindController : Controller
    {
        [HttpGet]
        public IActionResult NotFound()
        {
            return View("Views/Hospital/NotFound.cshtml");
        }

        [HttpPost]
        public IActionResult Find(string tempFind)
        {
            string[] tagsViews = {"ligue para nós+TalkToUs+Hospital",
                                    "contato+TalkToUs+Hospital",
                                    "chat+TalkToUs+Hospital",
                                    "mensagem+TalkToUs+Hospital",
                                    "contate-nos+TalkToUs+Hospital",
                                    "ajuda+TalkToUs+Hospital",
                                    "central de atendimento+TalkToUs+Hospital",
                                    "suporte+TalkToUs+Hospital",
                                    "telemedicina+TalkToUs+Hospital",
                                    "orientações+TalkToUs+Hospital",
                                    "agendamento+Hire+Hospital",
                                    "consulta+Hire+Hospital",
                                    "marcar consulta+Hire+Hospital",
                                    "consulta médica+Hire+Hospital",
                                    "marcar exame+Hire+Hospital",
                                    "quero contratar+Hire+Hospital",
                                    "atendimento+Hire+Hospital",
                                    "colaboração+Hire+Hospital",
                                    "trabalhe conosco+Hire+Hospital",
                                    "oportunidade+Hire+Hospital",
                                    "vaga+Hire+Hospital",
                                    "cadastro de paciente+IndexPaciente+Register",
                                    "novo paciente+IndexPaciente+Register",
                                    "registro de paciente+IndexPaciente+Register",
                                    "conta de paciente+IndexPaciente+Register",
                                    "ficha de paciente+IndexPaciente+Register",
                                    "cadastro de colaborador+IndexColaborador+Register",
                                    "registro de colaborador+IndexColaborador+Register",
                                    "novo colaborador+IndexColaborador+Register",
                                    "perfil de colaborador+IndexColaborador+Register",
                                    "ficha de colaborador+IndexColaborador+Register",
                                    "sobre nós+Readme+Hospital",
                                    "sobre+Readme+Hospital",
                                    "quem somos+Readme+Hospital",
                                    "missão+Readme+Hospital",
                                    "valores+Readme+Hospital",
                                    "história+Readme+Hospital",
                                    "nossa equipe+Readme+Hospital",
                                    "unidades+Readme+Hospital",
                                    "localização+Readme+Hospital",
                                    "responsabilidade social+Readme+Hospital",
                                    "visão+Readme+Hospital",
                                    "home+Index+Hospital",
                                    "pagina inicial+Index+Hospital",
                                    "início+Index+Hospital",
                                    "principal+Index+Hospital",
                                    "dashboard+Index+Hospital",
                                    "painel+Index+Hospital",
                                    "menu+Index+Hospital",
                                    "área do paciente+Index+Hospital",
                                    "área do colaborador+Index+Hospital",
                                    "portal+Index+Hospital",
                                    "homePage+Index+Hospital",
                                    "serviços+Index+Hospital"};

            foreach (string x in tagsViews)
            {
                if (x.Contains(tempFind.ToLower()))
                {
                    string[] tempTags = x.Split("+");

                    var view = tempTags[1].Replace(" ","");
                    var controller = tempTags[2].Replace(" ","");

                    return RedirectToAction(view, controller);
                }
                //return View("Views/Hospital/NotFound.cshtml");
            }
            return View("Views/Hospital/NotFound.cshtml");
        }

    }
}
