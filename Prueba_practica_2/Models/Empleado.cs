using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_practica_2.Models
{
    public class Empleado
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        [DataType(DataType.Date)]
        public DateTime fechaNacimiento { get; set; }
        public string email { get; set; }
        public int telefono { get; set; }
    }
}
