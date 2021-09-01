using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Repeticao.Para
{
    public class Exercicio3Model : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost(int Numero)
        {
            int fat = 1;

            List<string> fatorial = new List<string>();
            for (int i = 1; i <= Numero; i++)
            {
                fat *= i;
                fatorial.Add($"{fat}");
                ViewData["Fatorial"] = fatorial;
            }
        }
    }
}


