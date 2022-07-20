using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Packt.Shared
{
    public partial class BufeteContext : DbContext
    {
        public BufeteContext()
        {
        }

        public BufeteContext(DbContextOptions<BufeteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Caso> Casos { get; set; } = null!;
        public virtual DbSet<CasoDetalle> CasoDetalles { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Servicio> Servicios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Filename=Bufete.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CasoDetalle>(entity =>
            {
                entity.HasKey(e => new { e.DetalleId, e.CasoId});

                entity.HasOne(d => d.CasoDetalleNavigation)
                    .WithMany(p => p.CasoDetalles)
                    .HasForeignKey(d => d.DetalleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
