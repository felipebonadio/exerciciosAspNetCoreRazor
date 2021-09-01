using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Condicionais.Se
{
    public class Exercicio3Model : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost(double Saldo){
            double Credito = 0;
            if (Saldo <= 200)
			Credito = 0;
		    else if (Saldo >=201 && Saldo <= 400)
			Credito = Saldo * (0.2);
		    else if	(Saldo >=401 && Saldo <= 600)
			Credito = Saldo * (0.3);
		    else 
			Credito = Saldo *(0.4);
            
            ViewData["Resultado"]= $"Seu saldo médio é de R${Saldo} e seu crédito é de R${Credito}!";
            
        }
    }
}
