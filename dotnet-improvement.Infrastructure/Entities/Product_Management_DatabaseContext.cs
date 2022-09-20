using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace dotnet_improvement.Infrastructure.Entities
{
    public partial class Product_Management_DatabaseContext : DbContext
    {
        public Product_Management_DatabaseContext()
        {
        }

        public Product_Management_DatabaseContext(DbContextOptions<Product_Management_DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductFile> ProductFiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Product_Management_Database;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<File>(entity =>
            {
                entity.HasIndex(e => e.Name, "IX_Files_Name")
                    .IsUnique();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.CategoryId, "IX_Products_CategoryId");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId);
            });

            modelBuilder.Entity<ProductFile>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.FileId });

                entity.ToTable("Product_File");

                entity.HasIndex(e => e.FileId, "IX_Product_File_FileId");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.ProductFiles)
                    .HasForeignKey(d => d.FileId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductFiles)
                    .HasForeignKey(d => d.ProductId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
