using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GimnasioFinal.Models
{
    public class Clase
    {
        [Key]
        public int IdClase { get; set; }

        [Required]
        public string NombreClase { get; set; } = string.Empty;

        public string Instructor { get; set; } = string.Empty;

        // ✅ DateTime (NO TimeOnly)
        public DateTime Horario { get; set; }

        public int CuposDisponibles { get; set; }

        public ICollection<Reservacion>? Reservaciones { get; set; }
    }
}