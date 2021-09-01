using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Condicionais.Escolha
{
    public class Exercicio3Model : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost(int Idade)
        {
            switch (Idade)
            {
                case < 5:
                    ViewData["Resultado"] = $"Idade incompatível";
                    break;
                case <= 7:
                    ViewData["Resultado"] = $"Como você tem {Idade} anos, entrará para a categoria Infantil A";
                    break;
                case <= 10:
                    ViewData["Resultado"] = $"Como você tem {Idade} anos, entrará para a categoria Infantil B";
                    break;
                case <= 13:
                    ViewData["Resultado"] = $"Como você tem {Idade} anos, entrará para a categoria Juvenil A";
                    break;
                case <= 17:
                    ViewData["Resultado"] = $"Como você tem {Idade} anos, entrará para a categoria Juvenil B";
                    break;
                default:
                    ViewData["Resultado"] = $"Como você tem {Idade} anos, entrará para a categoria Adulto";
                    break;
            }
        }
    }
}