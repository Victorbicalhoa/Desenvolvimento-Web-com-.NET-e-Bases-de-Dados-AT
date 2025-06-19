using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace AgenciaTurismo.Pages.Exercicios.Exercicio03
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public int NumeroDiarias { get; set; }

        [BindProperty]
        public decimal ValorDiaria { get; set; }

        public decimal ValorTotal { get; set; }

        public bool ResultadoCalculado { get; set; } = false;

        public void OnPost()
        {
            Func<int, decimal, decimal> calcularTotal =
                (dias, valorDia) => dias * valorDia;

            ValorTotal = calcularTotal(NumeroDiarias, ValorDiaria);
            ResultadoCalculado = true;
        }
    }
}
