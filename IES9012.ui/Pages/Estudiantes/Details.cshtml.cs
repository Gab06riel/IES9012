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
    public class DetailsModel : PageModel
    {
        private readonly IES9012.ui.Data.IES9012Context _context;

        public DetailsModel(IES9012.ui.Data.IES9012Context context)
        {
            _context = context;
        }

      public Estudiante Estudiante { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Estudiantes == null)
            {
                return NotFound();
            }

            var estudiante = await _context.Estudiantes.FirstOrDefaultAsync(m => m.EstudianteId == id);
            if (estudiante == null)
            {
                return NotFound();
            }
            else 
            {
                Estudiante = estudiante;
            }
            return Page();
        }
    }
}
