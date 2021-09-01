using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Operadores
{
    public class Exercicio3Model : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost(string nome, double salario, double vendas)
        {
            var total = (vendas * 0.15) + salario;
            ViewData["Resultado"] = $"O vendedor {nome} possui um salário fixo de R${salario:N}, porém com a comissão seu salário total foi de R${total:N}.";
        }
    }
}
