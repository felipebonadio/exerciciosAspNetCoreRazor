using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Operadores
{
    public class Exercicio4Model : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost(int a, int b, int c)
        {
            var delta = Math.Pow(b,2) - 4 * a * c;
            var x1 =(-b + Math.Sqrt(delta)) / (2 *a);
            var x2 = (-b - Math.Sqrt(delta)) / (2*a); 
            ViewData["Resultado"] = $"O valor de delta é {delta}, o valor de X1 é {x1} e o valor de X2 é {x2}";
        }
    }
}
