using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Repeticao.Repita
{
    public class Exercicio2Model : PageModel
    {
        public void OnGet()
        {
        }
         public void OnPost(int Numero){
            
                List<string> impressao = new List<string>();
                int i = 0;
                do
                {
                    impressao.Add($"{i}");
                    i++;
                }  while(i<=Numero);
                ViewData["Impressao"] = impressao;
        }
    }
}

