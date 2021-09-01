using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Repeticao.Repita
{
    public class Exercicio3Model : PageModel
    {
        public void OnGet()
        {
        }
         public void OnPost(){
            
                List<string> impares = new List<string>();
                int i = 0;
                int aux = 0;
                do
                {
                    if (i % 2!=0){
                    aux = i *i;  
                    impares.Add($"{aux}");  
                    }
                    i++; 
                    
                    
                }  while(i<=15);
                ViewData["Impares"] = impares;
        }
    }
}



