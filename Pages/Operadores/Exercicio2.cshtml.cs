using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Operadores
{
    public class Exercicio2Model : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost(double cotacao, double dolar)
        {
            var conversao = dolar * cotacao;
            ViewData["Resultado"] = $"Você recebeu R${conversao:N2} por converter U${dolar:N2}, com a cotação do dolar no valor de R${cotacao:N2}.";
        }
    }
}
