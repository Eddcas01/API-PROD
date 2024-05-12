using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAcces.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Producto> Productos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseOracle("User Id=system;Password=V3rm0nt.9936;Data Source=localhost:1521/xe;");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("USING_NLS_COMP");

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.Idproducto)
                    .HasName("SYS_C008349");

                entity.ToTable("PRODUCTO");

                entity.Property(e => e.Idproducto)
                    .HasColumnType("NUMBER")
                    .HasColumnName("IDPRODUCTO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Idcaracteristica)
                    .HasColumnType("NUMBER")
                    .HasColumnName("IDCARACTERISTICA");

                entity.Property(e => e.Idcategoria)
                    .HasColumnType("NUMBER")
                    .HasColumnName("IDCATEGORIA");

                entity.Property(e => e.Idclasificacion)
                    .HasColumnType("NUMBER")
                    .HasColumnName("IDCLASIFICACION");

                entity.Property(e => e.Idsubcategoria)
                    .HasColumnType("NUMBER")
                    .HasColumnName("IDSUBCATEGORIA");

                entity.Property(e => e.Idtemporada)
                    .HasColumnType("NUMBER")
                    .HasColumnName("IDTEMPORADA");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
