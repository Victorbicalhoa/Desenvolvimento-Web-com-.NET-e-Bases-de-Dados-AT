using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgenciaTurismo.Models;

namespace AgenciaTurismo.Pages.Exercicios.Exercicio06
{
    public class CreatePacoteModel : PageModel
    {
        [BindProperty]
        public PacoteTuristico Pacote { get; set; } = new PacoteTuristico();

        public string? Mensagem { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            // Aqui você poderia salvar no banco
            Mensagem = $"Pacote '{Pacote.Titulo}' cadastrado com sucesso!";
            ModelState.Clear();
            Pacote = new PacoteTuristico();
            return Page();
        }
    }
}
