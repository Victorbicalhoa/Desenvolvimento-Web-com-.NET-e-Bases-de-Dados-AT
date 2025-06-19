using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgenciaTurismo.Models;
using AgenciaTurismo.Data;
using System;
using Microsoft.EntityFrameworkCore;

namespace AgenciaTurismo.Pages.Exercicios.Exercicio07
{
    public class CidadeDestinoDetailsModel(DbContexto context) : PageModel
    {
        private readonly DbContexto _context = context;

        [BindProperty]
        public CidadeDestino? CidadeDestino { get; set; }

        public IActionResult OnGet(int id)
        {
            CidadeDestino = _context.CidadeDestino
                .Include(c => c.PaisDestino) 
                .FirstOrDefault(c => c.Id == id);

            if (CidadeDestino == null)
                return NotFound();

            return Page();
        }
    }
}
