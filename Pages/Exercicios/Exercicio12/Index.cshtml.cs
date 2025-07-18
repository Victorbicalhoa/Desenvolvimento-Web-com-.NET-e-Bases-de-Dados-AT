﻿using System;
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
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly AgenciaTurismo.Data.DbContexto _context;

        public IndexModel(AgenciaTurismo.Data.DbContexto context)
        {
            _context = context;
        }

        public IList<PacoteTuristico> PacoteTuristico { get;set; } = default!;

        public async Task OnGetAsync()
        {
            PacoteTuristico = await _context.Pacotes
            .Where(p => p.DeletedAt == null)
            .ToListAsync();
        }
    }
}
