using DataCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCodeFirst.Contexts
{
    public class ComidaContexts : DbContext
    {
        public DbSet<Comida> Comida { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MSI;Database=Comidafirstcode;User ID=sa;password=SQL123;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comida>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.ToTable("Comida");
                entity.Property(e => e.Nombre).HasMaxLength(255).IsRequired();
                entity.Property(e => e.Categoria).HasMaxLength(255).IsRequired();
                entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)").IsRequired();
                entity.Property(e => e.TiempoPreparacionMin).IsRequired();
                entity.Property(e => e.EsVegetariano).IsRequired();
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
