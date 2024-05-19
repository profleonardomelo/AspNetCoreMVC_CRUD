using System.Text;

namespace Filmes_Mvc.Controllers
{
    public static class Util
    {
        private static readonly StringBuilder textoCodificado = new StringBuilder();

        public static string CodificarHtml(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return texto;

            textoCodificado.Clear();

            foreach (char c in texto)
            {
                switch (c)
                {
                    case '&':
                        textoCodificado.Append("&amp;");
                        break;
                    case '<':
                        textoCodificado.Append("&lt;");
                        break;
                    case '>':
                        textoCodificado.Append("&gt;");
                        break;
                    case '"':
                        textoCodificado.Append("&quot;");
                        break;
                    case '\'':
                        textoCodificado.Append("&#39;");
                        break;
                    case ' ':
                        textoCodificado.Append("&nbsp;");
                        break;
                    case '\n':
                        textoCodificado.Append("<br>");
                        break;
                    case '\t':
                        textoCodificado.Append("&nbsp;&nbsp;&nbsp;&nbsp;"); 
                        break;
                    default:
                        textoCodificado.Append(c);
                        break;
                }
            }

            return textoCodificado.ToString();
        }
    }
}

