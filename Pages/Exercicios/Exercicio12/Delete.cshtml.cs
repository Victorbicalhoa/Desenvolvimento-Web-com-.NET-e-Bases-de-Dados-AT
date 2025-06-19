using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AgenciaTurismo.Data;
using AgenciaTurismo.Models;
using Microsoft.AspNetCore.Authorization;

namespace AgenciaTurismo.Pages.Exercicios.Exercicio12
{
    public class DeleteModel : PageModel
    {
        private readonly AgenciaTurismo.Data.DbContexto _context;

        public DeleteModel(AgenciaTurismo.Data.DbContexto context)
        {
            _context = context;
        }

        [BindProperty]
        public PacoteTuristico PacoteTuristico { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pacoteturistico = await _context.Pacotes.FirstOrDefaultAsync(m => m.Id == id);

            if (pacoteturistico == null)
            {
                return NotFound();
            }
            else
            {
                PacoteTuristico = pacoteturistico;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Pacotes == null)
                return NotFound();

            var pacote = await _context.Pacotes.FindAsync(id);
            if (pacote == null)
                return NotFound();

            pacote.DeletedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
