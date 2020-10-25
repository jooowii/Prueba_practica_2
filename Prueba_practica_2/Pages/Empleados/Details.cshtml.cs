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
    public class DetailsModel : PageModel
    {
        private readonly Prueba_practica_2.Data.Prueba_practica_2Context _context;

        public DetailsModel(Prueba_practica_2.Data.Prueba_practica_2Context context)
        {
            _context = context;
        }

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
    }
}
