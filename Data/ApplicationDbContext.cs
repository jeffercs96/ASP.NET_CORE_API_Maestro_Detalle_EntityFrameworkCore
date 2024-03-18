using API_MaestroDetalle.Models;
using Microsoft.EntityFrameworkCore;

namespace API_MaestroDetalle.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetallePedido>()
                .Property(dp => dp.PrecioUnitario)
                .HasColumnType("decimal(18,2)"); // Especifica precisión y escala según tus necesidades
        }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetallePedido> DetallesPedidos { get; set; }

    }
}