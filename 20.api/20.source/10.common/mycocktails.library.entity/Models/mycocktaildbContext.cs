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
        public virtual DbSet<MMaterial> MMaterials { get; set; }
        public virtual DbSet<MMaterialCategory> MMaterialCategories { get; set; }
        public virtual DbSet<TCocktailMaterial> TCocktailMaterials { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=mycocktails_db;Username=postgres;Password=passwd;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Japanese_Japan.932");

            modelBuilder.Entity<MCocktail>(entity =>
            {
                entity.ToTable("m_cocktail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CreateAt).HasColumnName("create_at");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(1000)
                    .HasColumnName("remarks");

                entity.Property(e => e.UpdateAt).HasColumnName("update_at");
            });

            modelBuilder.Entity<MMaterial>(entity =>
            {
                entity.ToTable("m_material");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CreateAt).HasColumnName("create_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.UpdateAt).HasColumnName("update_at");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.MMaterials)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("m_material_category_id_fkey");
            });

            modelBuilder.Entity<MMaterialCategory>(entity =>
            {
                entity.ToTable("m_material_category");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CreateAt).HasColumnName("create_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.UpdateAt).HasColumnName("update_at");
            });

            modelBuilder.Entity<TCocktailMaterial>(entity =>
            {
                entity.HasKey(e => new { e.CocktailId, e.MaterialId })
                    .HasName("t_cocktail_material_pkey");

                entity.ToTable("t_cocktail_material");

                entity.Property(e => e.CocktailId).HasColumnName("cocktail_id");

                entity.Property(e => e.MaterialId).HasColumnName("material_id");

                entity.Property(e => e.CreateAt).HasColumnName("create_at");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.UpdateAt).HasColumnName("update_at");

                entity.HasOne(d => d.Cocktail)
                    .WithMany(p => p.TCocktailMaterials)
                    .HasForeignKey(d => d.CocktailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("t_cocktail_material_cocktail_id_fkey");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.TCocktailMaterials)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("t_cocktail_material_material_id_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
