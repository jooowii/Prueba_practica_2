using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Prueba_practica_2.Data;
using Prueba_practica_2.Models;

namespace Prueba_practica_2.Pages.Empleados
{
    public class CreateModel : PageModel
    {
        private readonly Prueba_practica_2.Data.Prueba_practica_2Context _context;

        public CreateModel(Prueba_practica_2.Data.Prueba_practica_2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Empleado Empleado { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Empleado.Add(Empleado);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
