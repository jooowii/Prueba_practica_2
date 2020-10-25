using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Prueba_practica_2.Data;
using Prueba_practica_2.Models;

namespace Prueba_practica_2.Pages.Empleados
{
    public class DeleteModel : PageModel
    {
        private readonly Prueba_practica_2.Data.Prueba_practica_2Context _context;

        public DeleteModel(Prueba_practica_2.Data.Prueba_practica_2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Empleado Empleado { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Empleado = await _context.Empleado.FirstOrDefaultAsync(m => m.ID == id);

            if (Empleado == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Empleado = await _context.Empleado.FindAsync(id);

            if (Empleado != null)
            {
                _context.Empleado.Remove(Empleado);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
