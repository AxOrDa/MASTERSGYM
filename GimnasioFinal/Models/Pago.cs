using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GimnasioFinal.Models 
{
    public class Pago
    {
        [Key]
        public int IdPago { get; set; }

        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        [Range(0.01, 999999.99, ErrorMessage = "El monto debe ser mayor a 0")]
        public decimal Monto { get; set; }

        public DateTime FechaPago { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "El tipo de membresía es requerido")]
        public string TipoMembresia { get; set; } = string.Empty;

        public Cliente? Cliente { get; set; }
    }
}