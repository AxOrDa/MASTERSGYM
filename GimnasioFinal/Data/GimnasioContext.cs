using GimnasioFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace GimnasioFinal.Data
{
    public class GimnasioContext : DbContext
    {
        public GimnasioContext(DbContextOptions<GimnasioContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Clase> Clases { get; set; }
        public DbSet<Reservacion> Reservaciones { get; set; }
        public DbSet<Pago> Pagos { get; set; }
    }
}
