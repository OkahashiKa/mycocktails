using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace mycocktails.library.entity.Models
{
    public partial class mycocktaildbContext : DbContext
    {
        public mycocktaildbContext()
        {
        }

        public mycocktaildbContext(DbContextOptions<mycocktaildbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MCocktail> MCocktails { get; set; }
        public virtual DbSet<MCocktailMaterial> MCocktailMaterials { get; set; }
        public virtual DbSet<MMaterial> MMaterials { get; set; }
        public virtual DbSet<MMaterialCategory> MMaterialCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=mycocktails.database.windows.net,1433;Initial Catalog=mycocktail-db;User ID=User;Password=P@ssword;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<MCocktail>(entity =>
            {
                entity.ToTable("m_cocktail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CreateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("create_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("update_at");
            });

            modelBuilder.Entity<MCocktailMaterial>(entity =>
            {
                entity.HasKey(e => new { e.CocktailId, e.MaterialId })
                    .HasName("PK__m_cockta__51DD22906E237349");

                entity.ToTable("m_cocktail_material");

                entity.Property(e => e.CocktailId).HasColumnName("cocktail_id");

                entity.Property(e => e.MaterialId).HasColumnName("material_id");

                entity.Property(e => e.CreateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("create_at");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("update_at");

                entity.HasOne(d => d.Cocktail)
                    .WithMany(p => p.MCocktailMaterials)
                    .HasForeignKey(d => d.CocktailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__m_cocktai__cockt__06CD04F7");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.MCocktailMaterials)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__m_cocktai__mater__07C12930");
            });

            modelBuilder.Entity<MMaterial>(entity =>
            {
                entity.ToTable("m_material");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CreateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("create_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("update_at");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.MMaterials)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__m_materia__categ__787EE5A0");
            });

            modelBuilder.Entity<MMaterialCategory>(entity =>
            {
                entity.ToTable("m_material_category");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CreateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("create_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.UpdateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("update_at");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
