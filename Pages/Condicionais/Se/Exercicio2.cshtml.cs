using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Condicionais.Se
{
    public class Exercicio2Model : PageModel
    {
        public void OnGet()
        {
        }
                public void OnPost(int Conta, double Saldo, double Debito, double Credito, double Total){
            Total = Saldo - Debito + Credito;
            if (Total >=0)
            ViewData["Resultado"]= $"Seu salto atual é de {Total} e está POSITIVO!";
            else
            ViewData["Resultado"]= $"Seu salto atual é de {Total} e está NEGATIVO!";
        }
    }
}
