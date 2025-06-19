using AgenciaTurismo.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace AgenciaTurismo.Data
{
    public class DbContexto(DbContextOptions<DbContexto> options) : DbContext(options)
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<PaisDestino> Paises { get; set; }
        public DbSet<CidadeDestino> CidadeDestino { get; set; }
        public DbSet<PacoteTuristico> Pacotes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PacoteTuristico>()
                .HasMany(p => p.Destinos);

            modelBuilder.Entity<Reserva>()
                .HasIndex(r => new { r.ClienteId, r.PacoteTuristicoId, r.DataReserva })
                .IsUnique(); // impede reservas duplicadas para mesma data
        }
    }
}
