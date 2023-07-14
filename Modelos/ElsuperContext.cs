using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace elsuper.Modelos;

public partial class ElsuperContext : DbContext
{
    public ElsuperContext()
    {
    }

    public ElsuperContext(DbContextOptions<ElsuperContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Staging> Stagings { get; set; }

    public virtual DbSet<Supermercado> Supermercados { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=elsuper;Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Compra>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("compra");

            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Descuento).HasColumnName("descuento");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Final).HasColumnName("final");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IdMarca).HasColumnName("id_marca");
            entity.Property(e => e.IdProducto).HasColumnName("id_producto");
            entity.Property(e => e.IdSupermercado).HasColumnName("id_supermercado");
            entity.Property(e => e.Precio).HasColumnName("precio");
            entity.Property(e => e.Total).HasColumnName("total");

            entity.HasOne(d => d.IdMarcaNavigation).WithMany()
                .HasForeignKey(d => d.IdMarca)
                .HasConstraintName("FK__compra__id_marca__2D27B809");

            entity.HasOne(d => d.IdProductoNavigation).WithMany()
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK__compra__id_produ__2C3393D0");

            entity.HasOne(d => d.IdSupermercadoNavigation).WithMany()
                .HasForeignKey(d => d.IdSupermercado)
                .HasConstraintName("FK__compra__id_super__2E1BDC42");
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__marca__3213E83FE3E042F2");

            entity.ToTable("marca");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__producto__3213E83F68C42923");

            entity.ToTable("producto");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Staging>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("staging");

            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Descuento).HasColumnName("descuento");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Final).HasColumnName("final");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Marca)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.Precio).HasColumnName("precio");
            entity.Property(e => e.Producto)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("producto");
            entity.Property(e => e.Supermercado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("supermercado");
            entity.Property(e => e.Total).HasColumnName("total");
        });

        modelBuilder.Entity<Supermercado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__supermer__3213E83F282A2E4F");

            entity.ToTable("supermercado");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
