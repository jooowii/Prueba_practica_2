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
    public class IndexModel : PageModel
    {
        private readonly Prueba_practica_2.Data.Prueba_practica_2Context _context;

        public IndexModel(Prueba_practica_2.Data.Prueba_practica_2Context context)
        {
            _context = context;
        }

        public IList<Empleado> Empleado { get;set; }

        public async Task OnGetAsync()
        {
            Empleado = await _context.Empleado.ToListAsync();
        }
    }
}
