using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicios.Pages.Condicionais.Escolha
{
    public class Exercicio2Model : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost(int Codigo, int qtde)
        {
            double valorConta;

            switch (Codigo)
            {
                case 100:
                    valorConta = qtde * 5.50;
                    ViewData["Resultado"] = $"Você comprou {qtde} cachorro quente(s) e o total da conta é R$ {valorConta:N2}";
                    break;

                case 101:
                    valorConta = qtde * 6.50;
                    ViewData["Resultado"] = $"Você comprou {qtde} bauru(s) simples e o total da conta é R$ {valorConta:N2}";
                    break;

                case 102:
                    valorConta = qtde * 7.50;
                    ViewData["Resultado"] = $"Você comprou {qtde} bauru(s) com ovo e o total da conta é R$ {valorConta:N2}";
                    break;

                case 103:
                    valorConta = qtde * 6.00;
                    ViewData["Resultado"] = $"Você comprou {qtde} hamburguer(s) e o total da conta é R$ {valorConta:N2}";
                    break;

                case 104:
                    valorConta = qtde * 6.30;
                    ViewData["Resultado"] = $"Você comprou {qtde} cheeseburguer(s) e o total da conta é R$ {valorConta:N2}";
                    break;

                case 105:
                    valorConta = qtde * 5.00;
                    ViewData["Resultado"] = $"Você comprou {qtde} refrigerante(s) e o total da conta é R$ {valorConta:N2}";
                    break;
                default:
                    Console.WriteLine("Produto Inexistente !!!");
                    break;
            }
        }
    }
}