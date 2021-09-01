using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Repeticao.Enquanto
{
    public class Exercicio2Model : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(int Numero){
            
                List<string> soma = new List<string>();
                int i =1;
                int aux=1;
                while(i<=Numero){
                    soma.Add($"{aux}");
                    aux = i+aux;
                    i++;
                }
                ViewData["Soma"] = soma;
            }
        }
    }
