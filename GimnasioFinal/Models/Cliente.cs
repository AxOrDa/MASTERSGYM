using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GimnasioFinal.Models 
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El apellido es requerido")]
        public string Apellido { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "Correo inválido")]
        public string Correo { get; set; } = string.Empty;

        public string Telefono { get; set; } = string.Empty;

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        public ICollection<Reservacion>? Reservaciones { get; set; }
        public ICollection<Pago>? Pagos { get; set; }
    }
}