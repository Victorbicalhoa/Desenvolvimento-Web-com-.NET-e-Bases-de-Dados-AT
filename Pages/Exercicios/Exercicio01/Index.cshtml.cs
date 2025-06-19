using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgenciaTurismo.Pages.Exercicios.Exercicio01
{
    public delegate decimal CalculateDelegate(decimal valorOriginal);

    public class IndexModel : PageModel
    {
        [BindProperty]
        public decimal ValorOriginal { get; set; }

        public decimal? ValorComDesconto { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            // desconto de 10%
            CalculateDelegate desconto = valor => valor * 0.9m;

            ValorComDesconto = desconto(ValorOriginal);
        }
    }
}
