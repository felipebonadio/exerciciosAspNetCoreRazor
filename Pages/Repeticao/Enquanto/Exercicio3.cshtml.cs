using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Repeticao.Enquanto
{
    public class Exercicio3Model : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost(int Numero)
        {
            int fat = 1;
            int i =1;
            List<string> fatorial = new List<string>();
           if (Numero == 0){
                fat =1;
                fatorial.Add($"{fat}");
                ViewData["Fatorial"] = fatorial;
                }
            while (i<=Numero){
                fat *= i;
                fatorial.Add($"{fat}");
                ViewData["Fatorial"] = fatorial;
                i++;
            }
            
        }
    }
}

