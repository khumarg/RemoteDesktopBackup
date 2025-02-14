using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IVPAPI_DBFirst.Models;

public partial class Ivplibrary3685Context : DbContext
{
    public Ivplibrary3685Context()
    {
    }

    public Ivplibrary3685Context(DbContextOptions<Ivplibrary3685Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BookDetail> BookDetails { get; set; }

    public virtual DbSet<BooksTest> BooksTests { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Publisher> Publishers { get; set; }

    public virtual DbSet<SubCategory> SubCategories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=192.168.0.13\\\\\\\\sqlexpress,49753; Database = IVPLibrary_3685; User Id = sa; Password = sa@12345678; TrustServerCertificate = True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.Property(e => e.AuthorId).HasColumnName("Author_Id");
            entity.Property(e => e.FirstName).HasMaxLength(50);

            entity.HasMany(d => d.Books).WithMany(p => p.AuthorsNavigation)
                .UsingEntity<Dictionary<string, object>>(
                    "BookAuthorMap",
                    r => r.HasOne<Book>().WithMany().HasForeignKey("BookId"),
                    l => l.HasOne<Author>().WithMany().HasForeignKey("AuthorId"),
                    j =>
                    {
                        j.HasKey("AuthorId", "BookId");
                        j.ToTable("BookAuthorMap");
                        j.HasIndex(new[] { "BookId" }, "IX_BookAuthorMap_BookID");
                        j.IndexerProperty<int>("AuthorId").HasColumnName("Author_Id");
                        j.IndexerProperty<int>("BookId").HasColumnName("BookID");
                    });

            entity.HasMany(d => d.BooksBooks).WithMany(p => p.Authors)
                .UsingEntity<Dictionary<string, object>>(
                    "AuthorBook",
                    r => r.HasOne<Book>().WithMany().HasForeignKey("BooksBookId"),
                    l => l.HasOne<Author>().WithMany().HasForeignKey("AuthorId"),
                    j =>
                    {
                        j.HasKey("AuthorId", "BooksBookId");
                        j.ToTable("AuthorBooks");
                        j.HasIndex(new[] { "BooksBookId" }, "IX_AuthorBooks_BooksBookID");
                        j.IndexerProperty<int>("AuthorId").HasColumnName("Author_Id");
                        j.IndexerProperty<int>("BooksBookId").HasColumnName("BooksBookID");
                    });
        });

        modelBuilder.Entity<Bank>(entity =>
        {
            entity.HasKey(e => e.Cid).HasName("PK__Bank__C1F8DC59E92ED0D7");

            entity.ToTable("Bank");

            entity.Property(e => e.Cid)
                .ValueGeneratedNever()
                .HasColumnName("CID");
            entity.Property(e => e.Cname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CName");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasIndex(e => e.PublisherId, "IX_Books_Publisher_Id");

            entity.Property(e => e.BookId).HasColumnName("BookID");
            entity.Property(e => e.Isbn)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("ISBN");
            entity.Property(e => e.Price).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.PublisherId).HasColumnName("Publisher_Id");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasDefaultValue("");

            entity.HasOne(d => d.Publisher).WithMany(p => p.Books).HasForeignKey(d => d.PublisherId);
        });

        modelBuilder.Entity<BookDetail>(entity =>
        {
            entity.HasKey(e => e.BookDetailsId);

            entity.Property(e => e.BookDetailsId).HasColumnName("BookDetails_Id");
        });

        modelBuilder.Entity<BooksTest>(entity =>
        {
            entity.HasKey(e => e.BookId);

            entity.ToTable("BooksTest");

            entity.Property(e => e.BookId).HasColumnName("BookID");
            entity.Property(e => e.Isbn).HasColumnName("ISBN");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.ToTable("publishers");

            entity.Property(e => e.PublisherId).HasColumnName("Publisher_Id");
        });

        modelBuilder.Entity<SubCategory>(entity =>
        {
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategory_Id");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
