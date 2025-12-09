using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GimnasioFinal.Models
{
    public class Reservacion
    {
        [Key]
        public int IdReservacion { get; set; }

        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }

        [ForeignKey("Clase")]
        public int IdClase { get; set; }

        public DateTime FechaReservacion { get; set; } = DateTime.Now;

        [Required]
        public string Estado { get; set; } = "Pendiente";
        
        public Cliente? Cliente { get; set; }
        public Clase? Clase { get; set; }
    }
}