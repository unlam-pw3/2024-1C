using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Clase7.EF.Data.EF;

public partial class Pw31cIslaTesoroContext : DbContext
{
    public Pw31cIslaTesoroContext()
    {
    }

    public Pw31cIslaTesoroContext(DbContextOptions<Pw31cIslaTesoroContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Tesoro> Tesoros { get; set; }

    public virtual DbSet<Ubicacion> Ubicacions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-JSSINJG\\SQLEXPRESS;Database=Pw3-1c-IslaTesoro;Trusted_Connection=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tesoro>(entity =>
        {
            entity.ToTable("Tesoro");

            entity.Property(e => e.ImagenRuta).HasMaxLength(300);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<Ubicacion>(entity =>
        {
            entity.ToTable("Ubicacion");

            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
