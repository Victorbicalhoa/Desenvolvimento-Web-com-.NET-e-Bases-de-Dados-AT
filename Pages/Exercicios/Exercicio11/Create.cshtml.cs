using AgenciaTurismo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgenciaTurismo.Data;

namespace AgenciaTurismo.Pages.Exercicios.Exercicio11;

public class CreateModel : PageModel
{
    private readonly DbContexto _context;

    public CreateModel(DbContexto context)
    {
        _context = context;
    }

    [BindProperty]
    public PacoteTuristico Pacote { get; set; } = new(); // <- ESTA LINHA É ESSENCIAL

    public IActionResult OnGet()
    {
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
            return Page();

        _context.Pacotes.Add(Pacote);
        await _context.SaveChangesAsync();

        return RedirectToPage("Index");
    }
}
