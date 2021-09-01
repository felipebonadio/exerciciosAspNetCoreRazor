using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Condicionais.Escolha
{
    public class Exercicio1Model : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost(double Peso, double Altura){
            double imc = Peso / Math.Pow(Altura, 2);
            ViewData["Resultado"]= $"Seu IMC é {imc:N2} e você está ";
            switch(imc){
                case < 20:
                ViewData["Resultado"] += "abaixo do peso";
                break;
                case < 25:
                ViewData["Resultado"] += "com peso normal";
                break;
                case < 30:
                ViewData["Resultado"] += "com sobre peso";
                break;
                case < 40:
                ViewData["Resultado"] += "obeso";
                break; 
                default:
                ViewData["Resultado"] += "com obesidade mórbida";
                break;
            }

        }
    }
}
