using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace mycocktails.library.entity.Models
{
    public partial class MyCocktailsDBContext : DbContext
    {
        public MyCocktailsDBContext()
        {
        }

        public MyCocktailsDBContext(DbContextOptions<MyCocktailsDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MCocktail> MCocktails { get; set; }
        public virtual DbSet<MCocktailRecipi> MCocktailRecipis { get; set; }
        public virtual DbSet<MMaterial> MMaterials { get; set; }
        public virtual DbSet<MMaterialCategory> MMaterialCategories { get; set; }
        public virtual DbSet<MRole> MRoles { get; set; }
        public virtual DbSet<MUser> MUsers { get; set; }
        public virtual DbSet<UserMaterial> UserMaterials { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=mycocktails-db;Username=postgress;Password=passwd");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "C");

            modelBuilder.Entity<MCocktail>(entity =>
            {
                entity.ToTable("m_cocktail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateAt).HasColumnName("create_at");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(1000)
                    .HasColumnName("remarks");

                entity.Property(e => e.UpdateAt).HasColumnName("update_at");
            });

            modelBuilder.Entity<MCocktailRecipi>(entity =>
            {
                entity.HasKey(e => new { e.CocktailId, e.MaterialId })
                    .HasName("m_cocktail_recipi_pkey");

                entity.ToTable("m_cocktail_recipi");

                entity.Property(e => e.CocktailId).HasColumnName("cocktail_id");

                entity.Property(e => e.MaterialId).HasColumnName("material_id");

                entity.Property(e => e.CreateAt).HasColumnName("create_at");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.UpdateAt).HasColumnName("update_at");

                entity.HasOne(d => d.Cocktail)
                    .WithMany(p => p.MCocktailRecipis)
                    .HasForeignKey(d => d.CocktailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("m_cocktail_recipi_cocktail_id_fkey");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.MCocktailRecipis)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("m_cocktail_recipi_material_id_fkey");
            });

            modelBuilder.Entity<MMaterial>(entity =>
            {
                entity.ToTable("m_material");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CreateAt).HasColumnName("create_at");

                entity.Property(e => e.Name)
                    .IsRequired()
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

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateAt).HasColumnName("create_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.UpdateAt).HasColumnName("update_at");
            });

            modelBuilder.Entity<MRole>(entity =>
            {
                entity.ToTable("m_role");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateAt).HasColumnName("create_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("name");

                entity.Property(e => e.UpdateAt).HasColumnName("update_at");
            });

            modelBuilder.Entity<MUser>(entity =>
            {
                entity.ToTable("m_user");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .HasColumnName("id");

                entity.Property(e => e.CreateAt).HasColumnName("create_at");

                entity.Property(e => e.FavoCocktailId).HasColumnName("favo_cocktail_id");

                entity.Property(e => e.Mail)
                    .HasMaxLength(100)
                    .HasColumnName("mail");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("password");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.UpdateAt).HasColumnName("update_at");

                entity.HasOne(d => d.FavoCocktail)
                    .WithMany(p => p.MUsers)
                    .HasForeignKey(d => d.FavoCocktailId)
                    .HasConstraintName("m_user_favo_cocktail_id_fkey");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.MUsers)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("m_user_role_id_fkey");
            });

            modelBuilder.Entity<UserMaterial>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.MaterialId })
                    .HasName("user_material_pkey");

                entity.ToTable("user_material");

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .HasColumnName("user_id");

                entity.Property(e => e.MaterialId).HasColumnName("material_id");

                entity.Property(e => e.CreateAt).HasColumnName("create_at");

                entity.Property(e => e.DeleteAt).HasColumnName("delete_at");

                entity.Property(e => e.UpdateAt).HasColumnName("update_at");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
