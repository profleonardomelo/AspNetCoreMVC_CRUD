using Microsoft.AspNetCore.Mvc;

namespace Filmes_Mvc.Controllers
{
    public class OlaMundoController : Controller
    {
        public string Index()
        {
            return "Esta é minha ação padrão (método Index) do controlador OlaMundo.";
        }

        public string BemVindo() 
        {
            return "Este é o método (ação) BemVindo do controlador OlaMundo.";
        }

        public string BemVindo2(string nome = "", int numero = 1, int id = 1)
        {
            nome = Util.CodificarHtml(nome);

            string mensagem = "";

            for (int i = 1; i <= numero; i++)
            {
                mensagem += i + " - Olá " + nome + "! --- ID: " + id + ".\n";
            }

            return mensagem;
        }
    }
}
