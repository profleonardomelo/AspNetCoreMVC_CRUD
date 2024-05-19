using Microsoft.AspNetCore.Mvc;

namespace Filmes_Mvc.Controllers
{
    public class OlaMundo2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listagem() 
        {
            return View();
        }

        public IActionResult BemVindo(string nome = "", int numero = 1, int id = 1)
        {
            nome = Util.CodificarHtml(nome);

            ViewData["Nome"] = nome;
            ViewData["Numero"] = numero;
            ViewData["Id"] = id;

            return View();
        }
    }
}
