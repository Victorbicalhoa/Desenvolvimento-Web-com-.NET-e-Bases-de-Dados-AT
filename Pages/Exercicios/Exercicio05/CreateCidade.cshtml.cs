using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgenciaTurismo.Models;
using System.ComponentModel.DataAnnotations;

namespace AgenciaTurismo.Pages.Exercicios.Exercicio05
{
    public class CreateCidadeModel : PageModel
    {
        [BindProperty]
        public CidadeDestino Cidade { get; set; } = new CidadeDestino();

        public string? Mensagem { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Aqui você poderia salvar no banco de dados, se desejar
            Mensagem = $"Cidade '{Cidade.Nome}' cadastrada com sucesso!";
            ModelState.Clear();
            Cidade = new CidadeDestino();
            return Page();
        }
    }
}
