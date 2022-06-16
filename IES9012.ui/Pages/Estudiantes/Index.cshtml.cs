using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IES9012.core.Modelos;
using IES9012.ui.Data;

namespace IES9012.ui.Pages.Estudiantes
{
    public class IndexModel : PageModel
    {
        private readonly IES9012.ui.Data.IES9012Context _context;

        public IndexModel(IES9012.ui.Data.IES9012Context context)
        {
            _context = context;
        }

        public IList<Estudiante> Estudiante { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Estudiantes != null)
            {
                Estudiante = await _context.Estudiantes.ToListAsync();
            }
        }
    }
}
