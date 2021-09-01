using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Repeticao.Para
{
    public class Exercicio2Model : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost()
        {
            int numero = 1;
            int ant = 0;
            List<string> fibo = new List<string>();
            for (int i = 1; i < 21; i++)
            {
                if (i == 1)
                {
                    numero = 1;
                    ant = 0;
                }
                else
                {
                    numero += ant;
                    ant = numero - ant;
                }
                fibo.Add($"{numero}");
                ViewData["Fibo"] = fibo;
            }
        }
    }
}

